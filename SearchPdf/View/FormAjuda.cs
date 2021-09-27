using System;
using System.Windows.Forms;
// ReSharper disable LocalizableElement

namespace SearchPdf.View
{
    public partial class FormAjuda : Form
    {
        public FormAjuda()
        {
            InitializeComponent();
        }

        private void FormAjuda_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
                Close();
        }

        private void FormAjuda_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;

            lblAplicativoVersao.Text = lblTitulo.Text + " - " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        }
    }
}
