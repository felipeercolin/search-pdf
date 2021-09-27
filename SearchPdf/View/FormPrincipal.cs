using System;
using System.IO;
using System.Windows.Forms;
using SearchPdf.NegocioXml;
using SearchPdf.Uteis;

// ReSharper disable LocalizableElement

namespace SearchPdf.View
{
    public partial class FormPrincipal : Form
    {
        public bool Desenvolvimento { get; set; }
        /// <summary>
        /// Metodo faz a chamada dos forms do sistema.
        /// </summary>
        /// <param name="numForm">Numero do Form - Paramentro do Tipo Interio.</param>
        private void ChamaForms(int numForm)
        {
            try
            {
                switch (numForm)
                {
                    case 1:
                        {
                            var newFormPessoa = new FormPessoa();
                            newFormPessoa.ShowDialog();
                        }
                        break;
                    case 2:
                        {
                            var newFormArquivosPdf = new FormArquivosPdf();
                            newFormArquivosPdf.ShowDialog();
                        }
                        break;
                    case 3:
                        {
                            var newFormLerPdf = new FormLerPdf();
                            newFormLerPdf.ShowDialog();
                        }
                        break;
                    case 4:
                        {
                            var newFormAjuda = new FormAjuda();
                            newFormAjuda.ShowDialog();
                        }
                        break;
                    case 9:
                        {
                            var newFormImportarExportar = new FormImportarExportar();
                            newFormImportarExportar.ShowDialog();
                        }
                        break;
                    case 10:
                        {
                            var newFormBackup = new FormBackup();
                            newFormBackup.ShowDialog();
                        }
                        break;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(@"Erro ao Inicializar Formulário à ser Chamado: " + erro.Message, @"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente Sair do Sistema?", "Sair do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            e.Cancel = result == DialogResult.No;
        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    ChamaForms(1);
                    break;
                case Keys.F2:
                    ChamaForms(2);
                    break;
                case Keys.F3:
                    ChamaForms(3);
                    break;
                case Keys.F9:
                    ChamaForms(9);
                    break;
                case Keys.F10:
                    ChamaForms(10);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Config.TipoConexao)
                {
                    case "sql":
                        tsslblDataSource.Text += @" " + Config.DataSource;
                        tsslblInitialCatalog.Text += @" " + Config.InitialCatalog;
                        break;
                    case "xml":
                        tsslblDataSource.Text = "Arquivo XML";
                        tsslblInitialCatalog.Visible = false;
                        var baseNegocioXml = new BaseNegocioXml();
                        baseNegocioXml.CreateXml();
                        break;
                    default:
                        tsslblDataSource.Visible = false;
                        tsslblInitialCatalog.Visible = false;
                        break;
                }

                //pega o path onde o exe esta
                var path = Path.GetDirectoryName(Application.ExecutablePath);
                Desenvolvimento = File.Exists(path + @"\desenvolvimentoercsystemtxt");

                button1.Visible = Desenvolvimento;
                lblDataHora.Text = "Data e Hora: " + DateTime.Now;
            }
            catch (Exception erro)
            {
                MessageBox.Show(@"Erro ao Inicializar: " + erro.Message, @"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmCadastroPessoa_Click(object sender, EventArgs e)
        {
            ChamaForms(1);
        }

        private void tsmCadastroPdf_Click(object sender, EventArgs e)
        {
            ChamaForms(2);
        }

        private void tsmLeituraPdfs_Click(object sender, EventArgs e)
        {
            ChamaForms(3);
        }

        private void tsmSistemaImportarExportar_Click(object sender, EventArgs e)
        {
            ChamaForms(9);
        }

        private void tsmSistemaBackup_Click(object sender, EventArgs e)
        {
            ChamaForms(10);
        }

        private void tsmAjuda_Click(object sender, EventArgs e)
        {
            ChamaForms(4);
        }

        private void tsbtCadastroPessoa_Click(object sender, EventArgs e)
        {
            ChamaForms(1);
        }

        private void tsbtCadastroPdf_Click(object sender, EventArgs e)
        {
            ChamaForms(2);
        }

        private void tsbtLeituraPdfs_Click(object sender, EventArgs e)
        {
            ChamaForms(3);
        }

        private void tsbtBackup_Click(object sender, EventArgs e)
        {
            ChamaForms(10);
        }

        private void tsbtAjuda_Click(object sender, EventArgs e)
        {
            ChamaForms(4);
        }

        private void tsbtSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newFormBase = new FormBase();
            newFormBase.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = "Data e Hora: " + DateTime.Now;
        }
    }
}
