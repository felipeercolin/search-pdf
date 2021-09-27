using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SearchPdf.Model;
using SearchPdf.Properties;
using SearchPdf.Service;
using SearchPdf.Uteis;
// ReSharper disable PossibleNullReferenceException

// ReSharper disable LocalizableElement

namespace SearchPdf.View
{
    public partial class FormPessoa : Form
    {
        private readonly PessoaService _pesService = new PessoaService();

        private void Pesquisar()
        {
            try
            {
                var pessoaId = txtCodigo.Text.Equals("") ? 0 : Convert.ToInt32(txtCodigo.Text);
                var listPesssoa = pessoaId == 0 ?_pesService.SelectTodos(txtNome.Text, chkDesativado.Checked) : new List<Pessoa> { _pesService.SelectPorId(pessoaId)};
                dataGridView1.DataSource = listPesssoa;
                lblQtdRegistros_qtd.Text = listPesssoa.Count.ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show(string.Format("Erro ao Consultar Dados: {0}", erro.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparGrid()
        {
            dataGridView1.DataSource = new List<Pessoa>();
            lblQtdRegistros_qtd.Text = "0";
        }

        private void PessoaDados(bool novo = true)
        {
            try
            {
                var formPessoaDados = new FormPessoaDados {oPessoa = new Pessoa()};
                if (dataGridView1.Rows.Count > 0 && !novo)
                {
                    var pessoaId = Convert.ToInt32(dataGridView1["colPessoaId", dataGridView1.CurrentRow.Index].Value);
                    if (pessoaId > 0)
                    {
                        var oPes = _pesService.SelectPorId(pessoaId);
                        if (oPes == null)
                        {
                            MessageBox.Show("Pessoa Não Encontrada!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        formPessoaDados.oPessoa = oPes;
                    }
                }
                formPessoaDados.ShowDialog();
                if (formPessoaDados.FezAlteracao) Pesquisar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(string.Format("Erro: {0}", erro.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtivarDesativar(bool todos = false)
        {
            try
            {
                if (DialogResult.Yes != MessageBox.Show("Deseja realmente fazer isso?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) return;

                if (dataGridView1.Rows.Count <= 0)
                {
                    MessageBox.Show("Nenhum Registro na Grid, por favor pesquise Registros para Realizar esse Procedimento.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var feito = false;
                if (todos)
                {
                    for (var i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        var pessoaId = Convert.ToInt32(dataGridView1["colPessoaId", i].Value);
                        feito = _pesService.UpdateAtivaDesativa(pessoaId, !chkDesativado.Checked);
                    }

                    var mensagem = feito ? string.Format("{0} de Todos os Registros da Grid foi realizada com sucesso", chkDesativado.Checked ? "Ativação" : "Desativação") : "Por algum motivo não foi possivel realizar procedimento!";
                    MessageBox.Show(mensagem, "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var pessoaId = Convert.ToInt32(dataGridView1["colPessoaId", dataGridView1.CurrentRow.Index].Value);
                    feito = _pesService.UpdateAtivaDesativa(pessoaId, !chkDesativado.Checked);
                    var mensagem = feito ? string.Format("{0} foi realizada com sucesso", chkDesativado.Checked ? "Ativação" : "Desativação") : "Por algum motivo não foi possivel realizar procedimento!";
                    MessageBox.Show(mensagem, "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (feito) Pesquisar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(string.Format("Erro ao {0} {2}: {1}", chkDesativado.Checked ? "Ativar" : "Desativar", erro.Message, todos ? "Todos da Grid": "Pessoa"), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FormPessoa()
        {
            InitializeComponent();
        }

        private void FormPessoa_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F9:
                    PessoaDados();
                    break;
                case Keys.F3:
                    Pesquisar();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void FormPessoa_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            PessoaDados();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Pesquisar();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Bloqueios.SomenteNumero(sender, e);
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Pesquisar();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PessoaDados(false);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            PessoaDados(false);
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            cmsGrip.Items[0].Text = cmsGrip.Items[0].Text.Replace(chkDesativado.Checked ? "Desativar" : "Ativar", chkDesativado.Checked ? "Ativar" : "Desativar");
            cmsGrip.Items[0].Image = chkDesativado.Checked ? Resources.baseline_visibility_black_18dp : Resources.baseline_visibility_off_black_18dp;
            cmsGrip.Items[1].Text = cmsGrip.Items[1].Text.Replace(chkDesativado.Checked ? "Desativar" : "Ativar", chkDesativado.Checked ? "Ativar" : "Desativar");
            cmsGrip.Items[1].Image = chkDesativado.Checked ? Resources.baseline_visibility_black_18dp : Resources.baseline_visibility_off_black_18dp;
        }

        private void cmsDesativarAtivarSelecionado_Click(object sender, EventArgs e)
        {
            AtivarDesativar();
        }

        private void cmsDesativarAtivarTodosGrid_Click(object sender, EventArgs e)
        {
            AtivarDesativar(true);
        }

        private void chkDesativado_CheckedChanged(object sender, EventArgs e)
        {
            LimparGrid();
        }
    }
}
