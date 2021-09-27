namespace SearchPdf.View
{
    partial class FormBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBackup));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSelecionarCaminho = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(190, 24);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Backup do Sistema";
            // 
            // btnSelecionarCaminho
            // 
            this.btnSelecionarCaminho.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarCaminho.Image")));
            this.btnSelecionarCaminho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionarCaminho.Location = new System.Drawing.Point(32, 63);
            this.btnSelecionarCaminho.Name = "btnSelecionarCaminho";
            this.btnSelecionarCaminho.Size = new System.Drawing.Size(142, 31);
            this.btnSelecionarCaminho.TabIndex = 7;
            this.btnSelecionarCaminho.Text = "Gerar Backup";
            this.btnSelecionarCaminho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionarCaminho.UseVisualStyleBackColor = true;
            this.btnSelecionarCaminho.Click += new System.EventHandler(this.btnSelecionarCaminho_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(191, 63);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(142, 31);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Fechar";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 106);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSelecionarCaminho);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBackup";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "010 - Backup do Sistema";
            this.Load += new System.EventHandler(this.FormBackup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBackup_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSelecionarCaminho;
        private System.Windows.Forms.Button btnSair;
    }
}