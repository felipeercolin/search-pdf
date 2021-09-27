using System;
using System.Windows.Forms;
using SearchPdf.Uteis;

// ReSharper disable LocalizableElement

namespace SearchPdf
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Rtf = @"{\rtf1\ansi This is in \b bold\b0.}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(richTextBox1.Rtf);
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            if(txtChave.Text == "" || txtTexto.Text == "") return;

            var cript = new Criptografar {Chave = txtChave.Text};
            txtTextoCriptografado.Text = cript.CriptografaSenha(txtTexto.Text);
        }
    }
}
