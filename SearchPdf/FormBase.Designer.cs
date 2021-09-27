namespace SearchPdf
{
    partial class FormBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbCriptografia = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtTextoCriptografado = new System.Windows.Forms.TextBox();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.lblChave = new System.Windows.Forms.Label();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.gbCriptografia.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(91, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(246, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "FormBase";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(392, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show Texto no MessageBox";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbCriptografia
            // 
            this.gbCriptografia.Controls.Add(this.lblResultado);
            this.gbCriptografia.Controls.Add(this.txtTextoCriptografado);
            this.gbCriptografia.Controls.Add(this.btnCriptografar);
            this.gbCriptografia.Controls.Add(this.lblTexto);
            this.gbCriptografia.Controls.Add(this.txtTexto);
            this.gbCriptografia.Controls.Add(this.lblChave);
            this.gbCriptografia.Controls.Add(this.txtChave);
            this.gbCriptografia.Location = new System.Drawing.Point(27, 208);
            this.gbCriptografia.Name = "gbCriptografia";
            this.gbCriptografia.Size = new System.Drawing.Size(392, 234);
            this.gbCriptografia.TabIndex = 3;
            this.gbCriptografia.TabStop = false;
            this.gbCriptografia.Text = "Criptografar";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(6, 121);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(78, 17);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtTextoCriptografado
            // 
            this.txtTextoCriptografado.Location = new System.Drawing.Point(90, 118);
            this.txtTextoCriptografado.Multiline = true;
            this.txtTextoCriptografado.Name = "txtTextoCriptografado";
            this.txtTextoCriptografado.ReadOnly = true;
            this.txtTextoCriptografado.Size = new System.Drawing.Size(296, 110);
            this.txtTextoCriptografado.TabIndex = 5;
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.Location = new System.Drawing.Point(90, 87);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(110, 25);
            this.btnCriptografar.TabIndex = 4;
            this.btnCriptografar.Text = "Criptografar";
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(38, 58);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(46, 17);
            this.lblTexto.TabIndex = 3;
            this.lblTexto.Text = "Texto:";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(90, 55);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(296, 25);
            this.txtTexto.TabIndex = 2;
            // 
            // lblChave
            // 
            this.lblChave.AutoSize = true;
            this.lblChave.Location = new System.Drawing.Point(30, 27);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(54, 17);
            this.lblChave.TabIndex = 1;
            this.lblChave.Text = "Chave:";
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(90, 24);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(296, 25);
            this.txtChave.TabIndex = 0;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 454);
            this.Controls.Add(this.gbCriptografia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBase";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBase";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCriptografia.ResumeLayout(false);
            this.gbCriptografia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbCriptografia;
        private System.Windows.Forms.Label lblChave;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnCriptografar;
        private System.Windows.Forms.TextBox txtTextoCriptografado;
        private System.Windows.Forms.Label lblResultado;
    }
}

