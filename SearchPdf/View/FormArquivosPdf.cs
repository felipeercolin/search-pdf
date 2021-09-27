using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SearchPdf.Uteis;
// ReSharper disable LocalizableElement

namespace SearchPdf.View
{
    public partial class FormArquivosPdf : Form
    {
        private void SelecionarPdf()
        {
            try
            {
                openFileDialog1.Title = "Selecione o Arquivo PDF que Deseja";
                openFileDialog1.Filter ="Arquivos PDF (*.pdf)|*.pdf";
                if (openFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("Procedimento Cancelado pelo Usuário!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (openFileDialog1.FileName.Equals(""))
                {
                    MessageBox.Show("Arquivo não Selecionado!!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                File.Copy(openFileDialog1.FileName, Config.CaminhoArquivos + @"\" + Path.GetFileName(openFileDialog1.FileName));
                MessageBox.Show("Arquivo Copiado com Sucesso!!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Pesquisar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Selecionar Arquivo PDF: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pesquisar()
        {
            try
            {

                if (!Directory.Exists(Config.CaminhoArquivos))
                {
                    Directory.CreateDirectory(Config.CaminhoArquivos);
                }

                var pesquisa = txtNome.Text.Equals("") ? "*.pdf" : "*" + txtNome.Text + "*.pdf";

                var arquivos = Directory.GetFiles(Config.CaminhoArquivos, pesquisa, SearchOption.AllDirectories).ToList()
                                        .Select(cd => new ViewModel.ViewModelArquivo
                                        {
                                            Caminho = cd,
                                            Nome = Path.GetFileName(cd.Replace(".PDF", "").Replace(".pdf", ""))
                                        }).OrderBy(cd => cd.Nome).ToList();

                dataGridView1.DataSource = arquivos;
                lblQtdRegistros_qtd.Text = arquivos.Count.ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Pesquiar Arquivos PDF: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FormArquivosPdf()
        {
            InitializeComponent();
        }

        private void FormArquivosPdf_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F9:
                    SelecionarPdf();
                    break;
                case Keys.F3:
                    Pesquisar();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void FormArquivosPdf_Load(object sender, EventArgs e)
        {
            Pesquisar();
            openFileDialog1.FileName = "";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            SelecionarPdf();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmRemoverArquivoSelecionado_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count <= 0) return;

                var caminho = dataGridView1[0, dataGridView1.CurrentRow?.Index ?? 0].Value + "";
                if (File.Exists(caminho))
                {
                    File.Delete(caminho);
                    MessageBox.Show("Arquivo Removido com Sucesso!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Pesquisar();
                }
                else MessageBox.Show("Arquivo não Encontado.\n\nCaminho: " + caminho, "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Remover Arquivo Selecionado.\nErro:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void tsmRemoverTodosArquivosDaGrid_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0) return;
            var removido = false;
            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var caminho = dataGridView1[0, i].Value + "";
                if (!File.Exists(caminho)) continue;

                File.Delete(caminho);
                removido = true;
            }

            if (!removido) return;

            MessageBox.Show("Arquivos Removidos com Sucesso!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Pesquisar();
        }
    }
}
