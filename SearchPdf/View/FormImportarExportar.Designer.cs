namespace SearchPdf.View
{
    partial class FormImportarExportar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportarExportar));
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblInformativo2 = new System.Windows.Forms.Label();
            this.linkExemploImportacao = new System.Windows.Forms.LinkLabel();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbStatusTodos = new System.Windows.Forms.RadioButton();
            this.rbStatusDesativados = new System.Windows.Forms.RadioButton();
            this.rbStatusAtivo = new System.Windows.Forms.RadioButton();
            this.gbCadastros = new System.Windows.Forms.GroupBox();
            this.rbCadastroPessoas = new System.Windows.Forms.RadioButton();
            this.lblInformativo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PanelPrincipal.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbCadastros.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPrincipal.BackColor = System.Drawing.Color.White;
            this.PanelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelPrincipal.Controls.Add(this.btnImportar);
            this.PanelPrincipal.Controls.Add(this.btnExportar);
            this.PanelPrincipal.Controls.Add(this.lblInformativo2);
            this.PanelPrincipal.Controls.Add(this.linkExemploImportacao);
            this.PanelPrincipal.Controls.Add(this.gbStatus);
            this.PanelPrincipal.Controls.Add(this.gbCadastros);
            this.PanelPrincipal.Controls.Add(this.lblInformativo);
            this.PanelPrincipal.Location = new System.Drawing.Point(14, 37);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(488, 262);
            this.PanelPrincipal.TabIndex = 16;
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImportar.Image = ((System.Drawing.Image)(resources.GetObject("btnImportar.Image")));
            this.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportar.Location = new System.Drawing.Point(126, 229);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(113, 26);
            this.btnImportar.TabIndex = 23;
            this.btnImportar.Text = "Importar";
            this.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(245, 229);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(113, 26);
            this.btnExportar.TabIndex = 22;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lblInformativo2
            // 
            this.lblInformativo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInformativo2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformativo2.ForeColor = System.Drawing.Color.DimGray;
            this.lblInformativo2.Location = new System.Drawing.Point(3, 43);
            this.lblInformativo2.Name = "lblInformativo2";
            this.lblInformativo2.Size = new System.Drawing.Size(476, 41);
            this.lblInformativo2.TabIndex = 4;
            this.lblInformativo2.Text = "Exportação será feita com arquivos de extensão \".xls\" ou \".xlsx\", ou seja, arquiv" +
    "os do Excel.";
            // 
            // linkExemploImportacao
            // 
            this.linkExemploImportacao.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkExemploImportacao.AutoSize = true;
            this.linkExemploImportacao.Location = new System.Drawing.Point(167, 20);
            this.linkExemploImportacao.Name = "linkExemploImportacao";
            this.linkExemploImportacao.Size = new System.Drawing.Size(197, 17);
            this.linkExemploImportacao.TabIndex = 3;
            this.linkExemploImportacao.TabStop = true;
            this.linkExemploImportacao.Text = "Exemplo Arquivo Importação.";
            this.linkExemploImportacao.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkExemploImportacao.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkExemploImportacao_LinkClicked);
            // 
            // gbStatus
            // 
            this.gbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStatus.Controls.Add(this.rbStatusTodos);
            this.gbStatus.Controls.Add(this.rbStatusDesativados);
            this.gbStatus.Controls.Add(this.rbStatusAtivo);
            this.gbStatus.Location = new System.Drawing.Point(3, 141);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(478, 50);
            this.gbStatus.TabIndex = 2;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbStatusTodos
            // 
            this.rbStatusTodos.AutoSize = true;
            this.rbStatusTodos.Location = new System.Drawing.Point(237, 20);
            this.rbStatusTodos.Name = "rbStatusTodos";
            this.rbStatusTodos.Size = new System.Drawing.Size(65, 21);
            this.rbStatusTodos.TabIndex = 2;
            this.rbStatusTodos.Text = "Todos";
            this.rbStatusTodos.UseVisualStyleBackColor = true;
            // 
            // rbStatusDesativados
            // 
            this.rbStatusDesativados.AutoSize = true;
            this.rbStatusDesativados.Location = new System.Drawing.Point(105, 20);
            this.rbStatusDesativados.Name = "rbStatusDesativados";
            this.rbStatusDesativados.Size = new System.Drawing.Size(107, 21);
            this.rbStatusDesativados.TabIndex = 1;
            this.rbStatusDesativados.Text = "Desativados";
            this.rbStatusDesativados.UseVisualStyleBackColor = true;
            // 
            // rbStatusAtivo
            // 
            this.rbStatusAtivo.AutoSize = true;
            this.rbStatusAtivo.Checked = true;
            this.rbStatusAtivo.Location = new System.Drawing.Point(6, 20);
            this.rbStatusAtivo.Name = "rbStatusAtivo";
            this.rbStatusAtivo.Size = new System.Drawing.Size(65, 21);
            this.rbStatusAtivo.TabIndex = 0;
            this.rbStatusAtivo.TabStop = true;
            this.rbStatusAtivo.Text = "Ativos";
            this.rbStatusAtivo.UseVisualStyleBackColor = true;
            // 
            // gbCadastros
            // 
            this.gbCadastros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCadastros.Controls.Add(this.rbCadastroPessoas);
            this.gbCadastros.Location = new System.Drawing.Point(3, 85);
            this.gbCadastros.Name = "gbCadastros";
            this.gbCadastros.Size = new System.Drawing.Size(478, 50);
            this.gbCadastros.TabIndex = 1;
            this.gbCadastros.TabStop = false;
            this.gbCadastros.Text = "Cadastros";
            // 
            // rbCadastroPessoas
            // 
            this.rbCadastroPessoas.AutoSize = true;
            this.rbCadastroPessoas.Checked = true;
            this.rbCadastroPessoas.Location = new System.Drawing.Point(6, 20);
            this.rbCadastroPessoas.Name = "rbCadastroPessoas";
            this.rbCadastroPessoas.Size = new System.Drawing.Size(84, 21);
            this.rbCadastroPessoas.TabIndex = 0;
            this.rbCadastroPessoas.TabStop = true;
            this.rbCadastroPessoas.Text = "Pessoas";
            this.rbCadastroPessoas.UseVisualStyleBackColor = true;
            // 
            // lblInformativo
            // 
            this.lblInformativo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInformativo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformativo.ForeColor = System.Drawing.Color.DimGray;
            this.lblInformativo.Location = new System.Drawing.Point(5, 3);
            this.lblInformativo.Name = "lblInformativo";
            this.lblInformativo.Size = new System.Drawing.Size(476, 34);
            this.lblInformativo.TabIndex = 0;
            this.lblInformativo.Text = "Arquivos de Importação devem ser com extensão \".xls\" ou \".xlsx\", ou seja, arquivo" +
    "s do Excel.";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(350, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(153, 26);
            this.btnFechar.TabIndex = 21;
            this.btnFechar.Text = "Fechar  ESC";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(14, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(184, 24);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Importar / Exportar";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormImportarExportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 308);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormImportarExportar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "009 - Importar / Exportar";
            this.Load += new System.EventHandler(this.FormImportarExportar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormImportarExportar_KeyDown);
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbCadastros.ResumeLayout(false);
            this.gbCadastros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblInformativo;
        private System.Windows.Forms.GroupBox gbCadastros;
        private System.Windows.Forms.RadioButton rbCadastroPessoas;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbStatusAtivo;
        private System.Windows.Forms.RadioButton rbStatusDesativados;
        private System.Windows.Forms.RadioButton rbStatusTodos;
        private System.Windows.Forms.LinkLabel linkExemploImportacao;
        private System.Windows.Forms.Label lblInformativo2;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
    }
}