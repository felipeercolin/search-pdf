using System;
using System.IO.Compression;
using System.Windows.Forms;
using SearchPdf.NegocioXml;
using SearchPdf.Uteis;
// ReSharper disable LocalizableElement

namespace SearchPdf.View
{
    public partial class FormBackup : Form
    {
        private void GerarBackcup()
        {
            try
            {
                if (Config.TipoConexao.Equals(""))
                {
                    MessageBox.Show("Tipo de Armazenamento não Informado!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var extensao = Config.TipoConexao.Equals("xml") ? ".zip" : Config.TipoConexao.Equals("sql") ? ".bak" : "";

                if (Config.TipoConexao.Equals(""))
                {
                    MessageBox.Show("Extenção de Arquivo não Encontrada!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                saveFileDialog1.Title = "Informe o Nome do Arquivo de Bakcup";
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.InitialDirectory = Config.CaminhoBackup;
                saveFileDialog1.FileName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + "_" + DateTime.Now.ToShortDateString().Replace("/", "-") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "-") + extensao;
                saveFileDialog1.Filter = Config.TipoConexao.Equals("xml") ? "Aquivo Zip (*.zip)|*.zip" : Config.TipoConexao.Equals("sql") ? "Backup (*.bak)|*.bak" : "Todo os Aquivos (*.)|*.";
                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("Procedimento Cancelado pelo Usuário!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (saveFileDialog1.FileName.Equals(""))
                {
                    MessageBox.Show("Nome do Arquivo não Selecionado ou Procedimento Cancelado pelo Usuário!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (Config.TipoConexao.Equals("xml"))
                {
                    ZipFile.CreateFromDirectory(Config.CaminhoAppData, saveFileDialog1.FileName);
                }
                else if (Config.TipoConexao.Equals("sql"))
                {
                    MessageBox.Show("Não Implementado!!!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (!Config.TipoConexao.Equals("")) MessageBox.Show("Backup realizado com Sucesso!!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Fazer Backup: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FormBackup()
        {
            InitializeComponent();
        }

        private void FormBackup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void FormBackup_Load(object sender, EventArgs e)
        {

        }

        private void btnSelecionarCaminho_Click(object sender, EventArgs e)
        {
            GerarBackcup();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
