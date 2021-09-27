using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using SearchPdf.Model;
using SearchPdf.Service;
using SearchPdf.Uteis;
using Path = System.IO.Path;

// ReSharper disable LocalizableElement

namespace SearchPdf.View
{
    public partial class FormLerPdf : Form
    {
        private string _texto = "";
        private void Carregar()
        {
            try
            {
                ReorganizarCampos();
                CarregarPdfs();
                CarregarPessoas();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Carregar Tela: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReorganizarCampos()
        {
            gbPessoasEncontradas.Visible = chkProcurarTodos.Checked;
            gbTexto.Size = chkProcurarTodos.Checked ? new Size(698, 466) : new Size(1011, 466);

            dataGridView1.DataSource = new List<Pessoa>();
            rtxtTexto.Text = _texto;
            cbPessoa.SelectedIndex = -1;
        }

        private void CarregarPdfs()
        {
            if (!Directory.Exists(Config.CaminhoArquivos))
            {
                Directory.CreateDirectory(Config.CaminhoArquivos);
            }

            var arquivos = Directory.GetFiles(Config.CaminhoArquivos, "*.pdf", SearchOption.AllDirectories).ToList()
                                    .Select(cd => new ViewModel.ViewModelArquivo
                                    {
                                        Caminho = cd,
                                        Nome = Path.GetFileName(cd.Replace(".PDF", "").Replace(".pdf", ""))
                                    }).ToList();

            cbPdf.DataSource = arquivos;
            cbPdf.DisplayMember = "Nome";
            cbPdf.ValueMember = "Caminho";
            cbPdf.SelectedValue = 0;

        }

        private void CarregarPessoas()
        {
            var pesService = new PessoaService();
            cbPessoa.DataSource = pesService.SelectTodos(false);
            cbPessoa.DisplayMember = "Nome";
            cbPessoa.ValueMember = "Nome";
            cbPessoa.SelectedValue = 0;
        }

        private void LerPdf()
        {
            try
            {
                if (string.IsNullOrEmpty(cbPdf.SelectedValue + ""))
                {
                    MessageBox.Show("Necessário Selecionar um arquivo PDF!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var pdfText = new StringBuilder();
                using (var pdfReader = new PdfReader(cbPdf.SelectedValue + ""))
                {
                    for (var i = 1; i <= pdfReader.NumberOfPages; i++)
                    {
                        var extractText = PdfTextExtractor.GetTextFromPage(pdfReader, i);
                        extractText = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(extractText)));
                        pdfText.Append(extractText);
                    }
                }
                _texto = pdfText.ToString();
                rtxtTexto.Text = pdfText.ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Ler PDF: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcurarPessoas()
        {
            try
            {
                if (rtxtTexto.Text.Equals(""))
                {
                    MessageBox.Show("Necessário Selecionar um arquivo PDF e Clicar em Ler PDF para Procurar Pessoa(s).", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (chkProcurarTodos.Checked && cbPessoa.Items.Count > 0)
                {
                    var texto = RemoveAcentos(_texto);
                    var listPessoa = (List<Pessoa>)cbPessoa.DataSource;
                    var listPessoaContains = new List<Pessoa>();
                    var listPositionsPessoaConta = new List<List<int>>();
                    dataGridView1.DataSource = new List<Pessoa>();
                    foreach (var pessoa in listPessoa)
                    {
                        var pessoaNome = RemoveAcentos(pessoa.Nome).TrimStart().TrimEnd().Trim();
                        var pessoaNomeSplited = pessoaNome.Split(' ').ToList();
                        var indexPessoaNomeExisteMaisOuMenos = -1;
                        var entrouExisteMaisOuMenos = false;
                        var listIndexNaoTem = new List<int>();
                        if (!Util.Contains(texto, pessoaNome, StringComparison.OrdinalIgnoreCase))
                        {
                            entrouExisteMaisOuMenos = true;
                            for (var i = pessoaNomeSplited.Count - 1; i > 0 && i <= pessoaNomeSplited.Count; i--)
                            {
                                if (indexPessoaNomeExisteMaisOuMenos != -1) continue;
                                var addLast = false;
                                string newPessoaNome;
                                if (listIndexNaoTem.Count > 0)
                                {
                                    newPessoaNome = pessoaNome;
                                    foreach (var index in listIndexNaoTem)
                                    {
                                        newPessoaNome = newPessoaNome.Replace(" " + pessoaNomeSplited[index], "");

                                        if (index == listIndexNaoTem.Last())
                                        {
                                            newPessoaNome = newPessoaNome.Replace(" " + pessoaNomeSplited[i], "");
                                            addLast = true;
                                        }
                                    }
                                }
                                else newPessoaNome = pessoaNome.Replace(" " + pessoaNomeSplited[i], "");

                                if (addLast) listIndexNaoTem.Add(i);

                                var existeMaisOuMenos = Util.Contains(texto, newPessoaNome, StringComparison.OrdinalIgnoreCase);
                                if (!existeMaisOuMenos && !listIndexNaoTem.Contains(i)) listIndexNaoTem.Add(i);
                                indexPessoaNomeExisteMaisOuMenos = existeMaisOuMenos ? i : -1;

                                i = existeMaisOuMenos ? 0 : i;
                            }
                        }

                        if (entrouExisteMaisOuMenos && indexPessoaNomeExisteMaisOuMenos > -1)
                        {
                            string pessoaNomeNewLine;
                            if (listIndexNaoTem.Count > 0)
                            {
                                pessoaNomeNewLine = pessoaNome;
                                foreach (var index in listIndexNaoTem)
                                {
                                    pessoaNomeNewLine = pessoaNomeNewLine.Replace(" " + pessoaNomeSplited[index], "");
                                }
                            }
                            else pessoaNomeNewLine = pessoaNome.Replace(" " + pessoaNomeSplited[indexPessoaNomeExisteMaisOuMenos], "");

                            var indexnome = texto.IndexOf(pessoaNomeNewLine, StringComparison.OrdinalIgnoreCase);
                            var nome = texto.Substring(indexnome, pessoaNome.Length + 1).Replace("\n", "").TrimStart().TrimEnd().Trim();

                            if (CompararNomes(nome, pessoaNome))
                            {
                                listPessoaContains.Add(new Pessoa { PessoaId = pessoa.PessoaId, Nome = pessoa.Nome + " **", Cadastro = pessoa.Cadastro, Desativa = pessoa.Desativa });
                                listPositionsPessoaConta.Add(new List<int> { indexnome, pessoaNome.Length + 1 });
                            }
                            else
                            {
                                nome = texto.Substring(indexnome, pessoaNome.Length + 1).Replace("\n", " ").TrimStart().TrimEnd().Trim();
                                if (!CompararNomes(nome, pessoaNome)) continue;

                                listPessoaContains.Add(new Pessoa { PessoaId = pessoa.PessoaId, Nome = pessoa.Nome + " **", Cadastro = pessoa.Cadastro, Desativa = pessoa.Desativa });
                                listPositionsPessoaConta.Add(new List<int> { indexnome, pessoaNome.Length + 1 });
                            }
                        }
                        else if (!entrouExisteMaisOuMenos && indexPessoaNomeExisteMaisOuMenos == -1)
                        {
                            var indexnome = texto.IndexOf(pessoaNome, StringComparison.OrdinalIgnoreCase);
                            var nome = texto.Substring(indexnome, pessoaNome.Length);

                            if (!CompararNomes(nome, pessoaNome)) continue;

                            listPessoaContains.Add(new Pessoa { PessoaId = pessoa.PessoaId, Nome = pessoa.Nome, Cadastro = pessoa.Cadastro, Desativa = pessoa.Desativa });
                            listPositionsPessoaConta.Add(new List<int> { indexnome, pessoaNome.Length + 1 });
                        }
                    }

                    var msg = listPessoaContains.Count > 0 ? "Pessoa(s) Encontrada(s) no Texto!\n\nNome da(s) Pessoa(s) estará em Negrito no Texto e estará na Grid ao Lado!" : "Pessoa(s) não Encontrada(s) no Texto!";
                    MessageBox.Show(msg, "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (listPessoaContains.Count <= 0) return;

                    texto = _texto;
                    foreach (var position in listPositionsPessoaConta)
                    {
                        var nome = texto.Substring(position[0], position[1]);
                        texto = texto.Replace(nome, @"\b " + nome + @" \b0");
                    }
                    texto = texto.Replace("\n", @"\par "); //quebra de linha
                    rtxtTexto.Text = "";
                    rtxtTexto.Rtf = @"{\rtf1\ansi " + texto + "}";
                    dataGridView1.DataSource = listPessoaContains;
                }
                else if (!string.IsNullOrEmpty(cbPessoa.SelectedValue + ""))
                {
                    var texto = RemoveAcentos(_texto);
                    var pessoa = RemoveAcentos(cbPessoa.SelectedValue + "");
                    var pessoaNomeSplited = pessoa.Split(' ').ToList();
                    var existe = false;
                    var indexPessoaNomeExisteMaisOuMenos = -1;
                    if (Util.Contains(texto, pessoa, StringComparison.OrdinalIgnoreCase))
                    {
                        var indexnome = texto.IndexOf(pessoa, StringComparison.OrdinalIgnoreCase);
                        var nome = texto.Substring(indexnome, pessoa.Length);

                        if (CompararNomes(nome, pessoa))
                        {
                            existe = true;
                            texto = _texto;
                            nome = texto.Substring(indexnome, pessoa.Length);

                            texto = texto.Replace("\n", @"\par "); //quebra de linha
                            texto = texto.Replace(nome, @"\b " + nome + @" \b0");
                            rtxtTexto.Text = "";
                            rtxtTexto.Rtf = @"{\rtf1\ansi " + texto + "}";
                        }
                    }
                    else
                    {
                        var listIndexNaoTem = new List<int>();
                        for (var i = pessoaNomeSplited.Count - 1; i > 0 && i <= pessoaNomeSplited.Count; i--)
                        {
                            if (indexPessoaNomeExisteMaisOuMenos != -1) continue;
                            string newPessoaNome;
                            var addLast = false;
                            if (listIndexNaoTem.Count > 0)
                            {
                                newPessoaNome = pessoa;
                                foreach (var index in listIndexNaoTem)
                                {
                                    newPessoaNome = newPessoaNome.Replace(" " + pessoaNomeSplited[index], "");

                                    if (index == listIndexNaoTem.Last())
                                    {
                                        newPessoaNome = newPessoaNome.Replace(" " + pessoaNomeSplited[i], "");
                                        addLast = true;
                                    }
                                }
                            }
                            else newPessoaNome = pessoa.Replace(" " + pessoaNomeSplited[i], "");

                            if (addLast) listIndexNaoTem.Add(i);

                            var existeMaisOuMenos = Util.Contains(texto, newPessoaNome, StringComparison.OrdinalIgnoreCase);
                            indexPessoaNomeExisteMaisOuMenos = existeMaisOuMenos ? i : -1;
                            if (!existeMaisOuMenos && !listIndexNaoTem.Contains(i)) listIndexNaoTem.Add(i);
                            i = existeMaisOuMenos ? 0 : i;
                        }

                        if (indexPessoaNomeExisteMaisOuMenos > -1)
                        {

                            string pessoaNomeNewLine;
                            if (listIndexNaoTem.Count > 0)
                            {
                                pessoaNomeNewLine = pessoa;
                                foreach (var index in listIndexNaoTem)
                                {
                                    pessoaNomeNewLine = pessoaNomeNewLine.Replace(" " + pessoaNomeSplited[index], "");
                                }
                            }
                            else pessoaNomeNewLine = pessoa.Replace(" " + pessoaNomeSplited[indexPessoaNomeExisteMaisOuMenos], "");

                            var indexnome = texto.IndexOf(pessoaNomeNewLine, StringComparison.OrdinalIgnoreCase);
                            var nome = texto.Substring(indexnome, pessoa.Length + 1).Replace("\n", "").TrimStart().TrimEnd().Trim();

                            if (CompararNomes(nome, pessoa))
                            {
                                existe = true;
                                texto = _texto;
                                nome = texto.Substring(indexnome, pessoa.Length + 1);
                                nome = nome.Replace("\n", @"\par ");
                                texto = texto.Replace("\n", @"\par "); //quebra de linha
                                texto = texto.Replace(nome, @"\b " + nome + @" \b0");
                                rtxtTexto.Text = "";
                                rtxtTexto.Rtf = @"{\rtf1\ansi " + texto + "}";
                            }
                            if (!existe)
                            {
                                nome = texto.Substring(indexnome, pessoa.Length + 1).Replace("\n", " ").TrimStart().TrimEnd().Trim();
                                if (CompararNomes(nome, pessoa))
                                {
                                    existe = true;
                                    texto = _texto;
                                    nome = texto.Substring(indexnome, pessoa.Length);
                                    nome = nome.Replace("\n", @"\par ");
                                    texto = texto.Replace("\n", @"\par "); //quebra de linha
                                    texto = texto.Replace(nome, @"\b " + nome + @" \b0");
                                    rtxtTexto.Text = "";
                                    rtxtTexto.Rtf = @"{\rtf1\ansi " + texto + "}";
                                }
                            }
                        }
                    }

                    var msg = existe ? "Pessoa Encontrada no Texto!\n\nNome da Pessoa estará em Negrito no Texto!" : "Pessoa não Encontrada no Texto!";
                    MessageBox.Show(msg, "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Necessário Selecionar uma Pessoa ou Marcar a Flag \"Procurar Todas as Pessoas\"!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Procurar Pessoa(s): " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool CompararNomes(string nome, string pessoaNome)
        {
            var nomeComparar = nome.ToLower().Trim();

            var pessoaNomeComparar = pessoaNome.ToLower().Trim();

            return nomeComparar.Equals(pessoaNomeComparar);
        }

        private static string RemoveAcentos(string texto)
        {
            var normalizedString = texto.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        public FormLerPdf()
        {
            InitializeComponent();
        }

        private void FormLerPdf_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void FormLerPdf_Load(object sender, EventArgs e)
        {
            Carregar();
        }

        private void cbPdf_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_texto)) return;

            _texto = "";
            ReorganizarCampos();
        }

        private void btnLerPdf_Click(object sender, EventArgs e)
        {
            LerPdf();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            ProcurarPessoas();
        }

        private void chkProcurarTodos_CheckedChanged(object sender, EventArgs e)
        {
            ReorganizarCampos();
        }

        public bool IsAllUpper(string input)
        {
            return input.All(t => char.IsUpper(t));
        }
    }
}
