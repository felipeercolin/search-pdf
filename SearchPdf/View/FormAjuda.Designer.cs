namespace SearchPdf.View
{
    partial class FormAjuda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjuda));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.lblAplicativoVersao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(200, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(109, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SearchPDF";
            // 
            // lblTexto
            // 
            this.lblTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTexto.Location = new System.Drawing.Point(12, 31);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(485, 218);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = resources.GetString("lblTexto.Text");
            // 
            // lblContato
            // 
            this.lblContato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContato.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.Location = new System.Drawing.Point(12, 264);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(485, 55);
            this.lblContato.TabIndex = 2;
            this.lblContato.Text = "Para mais informações entrar em contato.\r\nContato: Felipe Ercolin\r\nCelular: +55 (" +
    "63) 98136-1994";
            // 
            // lblAplicativoVersao
            // 
            this.lblAplicativoVersao.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAplicativoVersao.AutoSize = true;
            this.lblAplicativoVersao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAplicativoVersao.Location = new System.Drawing.Point(178, 339);
            this.lblAplicativoVersao.Name = "lblAplicativoVersao";
            this.lblAplicativoVersao.Size = new System.Drawing.Size(125, 15);
            this.lblAplicativoVersao.TabIndex = 3;
            this.lblAplicativoVersao.Text = "SearchPDF - v.1.0.0.0";
            // 
            // FormAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 365);
            this.Controls.Add(this.lblAplicativoVersao);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(458, 272);
            this.Name = "FormAjuda";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuda";
            this.Load += new System.EventHandler(this.FormAjuda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAjuda_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.Label lblAplicativoVersao;
    }
}