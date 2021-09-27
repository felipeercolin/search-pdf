using System;
using System.Globalization;
using System.Windows.Forms;
using SearchPdf.Model;
using SearchPdf.Service;

// ReSharper disable LocalizableElement

namespace SearchPdf.View
{
    public partial class FormPessoaDados : Form
    {
        private readonly PessoaService _pesService = new PessoaService();

        public Pessoa oPessoa { get; set; }
        public bool FezAlteracao { get; set; }

        private void Gravar()
        {
            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Nome é Obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var nome = txtNome.Text;
                var objPessoa = new Pessoa { PessoaId = oPessoa.PessoaId, Nome = nome };
                var newPessoa = _pesService.Save(objPessoa);
                if (newPessoa.PessoaId > 0)
                {
                    MessageBox.Show("Gravado com Sucesso!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (oPessoa.PessoaId == 0)
                    {
                        txtCodigo.Text = "0";
                        txtNome.Text = "";
                    }

                    FezAlteracao = true;
                }
                else MessageBox.Show("Por algum motivo não foi possivel Gravar os dados!\nTente Novamente Mais Tarde!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Gravar Dados: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Carregar()
        {
            try
            {
                txtCodigo.Text = oPessoa.PessoaId + "";
                txtNome.Text = oPessoa.Nome;
                txtNome.Focus();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Carregar Tela: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FormPessoaDados()
        {
            InitializeComponent();
        }

        private void FormPessoaDados_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F9:
                    Gravar();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void FormPessoaDados_Load(object sender, EventArgs e)
        {
            Carregar();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
