using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using SearchPdf.Model;
using SearchPdf.Service;

// ReSharper disable LocalizableElement

namespace SearchPdf.View
{
    public partial class FormImportarExportar : Form
    {
        private void Importar()
        {
            try
            {
                if (!rbCadastroPessoas.Checked)
                {
                    MessageBox.Show("Tipo de Cadastro não Selecionado!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                openFileDialog1.Title = "Selecione o Arquivo de Excel que Deseja";
                openFileDialog1.Filter = "Arquivos Excel 2003 (*.xls)|*.xls|Arquivos Excel 2007/Superior (*.xlsx)|*.xlsx";
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

                if (!System.IO.File.Exists(openFileDialog1.FileName))
                {
                    MessageBox.Show("Arquivo Não Existe!!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var xlsApp = new Microsoft.Office.Interop.Excel.Application();
                var wb = xlsApp.Workbooks.Open(openFileDialog1.FileName,0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true);
                var sheets = wb.Worksheets;
                var ws = (Worksheet)sheets.Item[1];

                var firstColumn = ws.UsedRange.Columns[1];
                var myvalues = (Array)firstColumn.Cells.Value;
                var list = myvalues.OfType<object>().Select(o => o.ToString()).ToList();
                if (list.Count <= 0)
                {
                    MessageBox.Show("Nenhum Registro Encontrado no Arquivo!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (rbCadastroPessoas.Checked)
                {
                    var pesService = new PessoaService();
                    foreach (var item in list)
                    {
                        pesService.Save(new Pessoa { Nome = item });
                    } 
                }

                MessageBox.Show("Arquivo Imporado com Sucesso!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Importar Arquivo.\nErro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); throw;
            }
        }

        public FormImportarExportar()
        {
            InitializeComponent();
        }

        private void FormImportarExportar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void FormImportarExportar_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkExemploImportacao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var newFormExemploImportacao = new FormExemploImportacao();
            newFormExemploImportacao.ShowDialog();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            Importar();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recurso de Exportação não Implementado!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
