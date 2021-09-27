namespace SearchPdf.View
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastroPessoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastroPdf = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLeituraPdfs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSistemaBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuRapido = new System.Windows.Forms.ToolStrip();
            this.tsbtCadastroPessoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtCadastroPdf = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtLeituraPdfs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtBackup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtAjuda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtSair = new System.Windows.Forms.ToolStripButton();
            this.ssBarraFerramenta = new System.Windows.Forms.StatusStrip();
            this.tsslblDataSource = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblInitialCatalog = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDataHora = new System.Windows.Forms.Label();
            this.tsmSistemaImportarExportar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.tsMenuRapido.SuspendLayout();
            this.ssBarraFerramenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastro,
            this.tsmLeituraPdfs,
            this.tsmSistema,
            this.tsmAjuda,
            this.tsmSair});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1066, 25);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // tsmCadastro
            // 
            this.tsmCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastroPessoa,
            this.tsmCadastroPdf});
            this.tsmCadastro.Name = "tsmCadastro";
            this.tsmCadastro.Size = new System.Drawing.Size(80, 21);
            this.tsmCadastro.Text = "Cadastro";
            // 
            // tsmCadastroPessoa
            // 
            this.tsmCadastroPessoa.Image = ((System.Drawing.Image)(resources.GetObject("tsmCadastroPessoa.Image")));
            this.tsmCadastroPessoa.Name = "tsmCadastroPessoa";
            this.tsmCadastroPessoa.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tsmCadastroPessoa.Size = new System.Drawing.Size(152, 22);
            this.tsmCadastroPessoa.Text = "Pessoa";
            this.tsmCadastroPessoa.Click += new System.EventHandler(this.tsmCadastroPessoa_Click);
            // 
            // tsmCadastroPdf
            // 
            this.tsmCadastroPdf.Image = ((System.Drawing.Image)(resources.GetObject("tsmCadastroPdf.Image")));
            this.tsmCadastroPdf.Name = "tsmCadastroPdf";
            this.tsmCadastroPdf.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsmCadastroPdf.Size = new System.Drawing.Size(152, 22);
            this.tsmCadastroPdf.Text = "PDF";
            this.tsmCadastroPdf.Click += new System.EventHandler(this.tsmCadastroPdf_Click);
            // 
            // tsmLeituraPdfs
            // 
            this.tsmLeituraPdfs.Name = "tsmLeituraPdfs";
            this.tsmLeituraPdfs.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.tsmLeituraPdfs.Size = new System.Drawing.Size(129, 21);
            this.tsmLeituraPdfs.Text = "Leitura de PDF\'s";
            this.tsmLeituraPdfs.Click += new System.EventHandler(this.tsmLeituraPdfs_Click);
            // 
            // tsmSistema
            // 
            this.tsmSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSistemaImportarExportar,
            this.tsmSistemaBackup});
            this.tsmSistema.Name = "tsmSistema";
            this.tsmSistema.Size = new System.Drawing.Size(74, 21);
            this.tsmSistema.Text = "Sistema";
            // 
            // tsmSistemaBackup
            // 
            this.tsmSistemaBackup.Image = ((System.Drawing.Image)(resources.GetObject("tsmSistemaBackup.Image")));
            this.tsmSistemaBackup.Name = "tsmSistemaBackup";
            this.tsmSistemaBackup.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.tsmSistemaBackup.Size = new System.Drawing.Size(222, 22);
            this.tsmSistemaBackup.Text = "Backup";
            this.tsmSistemaBackup.Click += new System.EventHandler(this.tsmSistemaBackup_Click);
            // 
            // tsmAjuda
            // 
            this.tsmAjuda.Name = "tsmAjuda";
            this.tsmAjuda.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.tsmAjuda.Size = new System.Drawing.Size(56, 21);
            this.tsmAjuda.Text = "Ajuda";
            this.tsmAjuda.Click += new System.EventHandler(this.tsmAjuda_Click);
            // 
            // tsmSair
            // 
            this.tsmSair.Name = "tsmSair";
            this.tsmSair.Size = new System.Drawing.Size(46, 21);
            this.tsmSair.Text = "Sair";
            // 
            // tsMenuRapido
            // 
            this.tsMenuRapido.AutoSize = false;
            this.tsMenuRapido.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenuRapido.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtCadastroPessoa,
            this.toolStripSeparator4,
            this.tsbtCadastroPdf,
            this.tsSeparator1,
            this.tsbtLeituraPdfs,
            this.toolStripSeparator3,
            this.tsbtBackup,
            this.toolStripSeparator1,
            this.tsbtAjuda,
            this.toolStripSeparator2,
            this.tsbtSair});
            this.tsMenuRapido.Location = new System.Drawing.Point(0, 25);
            this.tsMenuRapido.Name = "tsMenuRapido";
            this.tsMenuRapido.Size = new System.Drawing.Size(1066, 52);
            this.tsMenuRapido.TabIndex = 13;
            this.tsMenuRapido.Text = "Menu Rapido";
            // 
            // tsbtCadastroPessoa
            // 
            this.tsbtCadastroPessoa.Image = ((System.Drawing.Image)(resources.GetObject("tsbtCadastroPessoa.Image")));
            this.tsbtCadastroPessoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtCadastroPessoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtCadastroPessoa.Name = "tsbtCadastroPessoa";
            this.tsbtCadastroPessoa.Size = new System.Drawing.Size(75, 49);
            this.tsbtCadastroPessoa.Text = "Pessoas - F1";
            this.tsbtCadastroPessoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtCadastroPessoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtCadastroPessoa.Click += new System.EventHandler(this.tsbtCadastroPessoa_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 52);
            // 
            // tsbtCadastroPdf
            // 
            this.tsbtCadastroPdf.Image = ((System.Drawing.Image)(resources.GetObject("tsbtCadastroPdf.Image")));
            this.tsbtCadastroPdf.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtCadastroPdf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtCadastroPdf.Name = "tsbtCadastroPdf";
            this.tsbtCadastroPdf.Size = new System.Drawing.Size(105, 49);
            this.tsbtCadastroPdf.Text = "Arquivos PDF - F2";
            this.tsbtCadastroPdf.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtCadastroPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtCadastroPdf.Click += new System.EventHandler(this.tsbtCadastroPdf_Click);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // tsbtLeituraPdfs
            // 
            this.tsbtLeituraPdfs.Image = ((System.Drawing.Image)(resources.GetObject("tsbtLeituraPdfs.Image")));
            this.tsbtLeituraPdfs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtLeituraPdfs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtLeituraPdfs.Name = "tsbtLeituraPdfs";
            this.tsbtLeituraPdfs.Size = new System.Drawing.Size(118, 49);
            this.tsbtLeituraPdfs.Text = "Leitura de PDF\'s - F3";
            this.tsbtLeituraPdfs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtLeituraPdfs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtLeituraPdfs.Click += new System.EventHandler(this.tsbtLeituraPdfs_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 52);
            // 
            // tsbtBackup
            // 
            this.tsbtBackup.Image = ((System.Drawing.Image)(resources.GetObject("tsbtBackup.Image")));
            this.tsbtBackup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtBackup.Name = "tsbtBackup";
            this.tsbtBackup.Size = new System.Drawing.Size(79, 49);
            this.tsbtBackup.Text = "Backup - F10";
            this.tsbtBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtBackup.Click += new System.EventHandler(this.tsbtBackup_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // tsbtAjuda
            // 
            this.tsbtAjuda.Image = ((System.Drawing.Image)(resources.GetObject("tsbtAjuda.Image")));
            this.tsbtAjuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtAjuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtAjuda.Name = "tsbtAjuda";
            this.tsbtAjuda.Size = new System.Drawing.Size(42, 49);
            this.tsbtAjuda.Text = "Ajuda";
            this.tsbtAjuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtAjuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtAjuda.Click += new System.EventHandler(this.tsbtAjuda_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // tsbtSair
            // 
            this.tsbtSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbtSair.Image")));
            this.tsbtSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtSair.Name = "tsbtSair";
            this.tsbtSair.Size = new System.Drawing.Size(61, 49);
            this.tsbtSair.Text = "Sair - ESC";
            this.tsbtSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtSair.Click += new System.EventHandler(this.tsbtSair_Click);
            // 
            // ssBarraFerramenta
            // 
            this.ssBarraFerramenta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssBarraFerramenta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblDataSource,
            this.tsslblInitialCatalog});
            this.ssBarraFerramenta.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ssBarraFerramenta.Location = new System.Drawing.Point(0, 586);
            this.ssBarraFerramenta.Name = "ssBarraFerramenta";
            this.ssBarraFerramenta.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.ssBarraFerramenta.ShowItemToolTips = true;
            this.ssBarraFerramenta.Size = new System.Drawing.Size(1066, 22);
            this.ssBarraFerramenta.TabIndex = 14;
            this.ssBarraFerramenta.Text = "Dados de Inicialização";
            // 
            // tsslblDataSource
            // 
            this.tsslblDataSource.Name = "tsslblDataSource";
            this.tsslblDataSource.Size = new System.Drawing.Size(82, 17);
            this.tsslblDataSource.Text = "Data Source:";
            // 
            // tsslblInitialCatalog
            // 
            this.tsslblInitialCatalog.Name = "tsslblInitialCatalog";
            this.tsslblInitialCatalog.Size = new System.Drawing.Size(90, 17);
            this.tsslblInitialCatalog.Text = "Initial Catalog:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDataHora
            // 
            this.lblDataHora.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.Location = new System.Drawing.Point(361, 559);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(345, 27);
            this.lblDataHora.TabIndex = 16;
            this.lblDataHora.Text = "Data e Hora: 22/22/22 22:00:00";
            // 
            // tsmSistemaImportarExportar
            // 
            this.tsmSistemaImportarExportar.Image = ((System.Drawing.Image)(resources.GetObject("tsmSistemaImportarExportar.Image")));
            this.tsmSistemaImportarExportar.Name = "tsmSistemaImportarExportar";
            this.tsmSistemaImportarExportar.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.tsmSistemaImportarExportar.Size = new System.Drawing.Size(222, 22);
            this.tsmSistemaImportarExportar.Text = "Importar / Exportar";
            this.tsmSistemaImportarExportar.Click += new System.EventHandler(this.tsmSistemaImportarExportar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 608);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ssBarraFerramenta);
            this.Controls.Add(this.tsMenuRapido);
            this.Controls.Add(this.menuPrincipal);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1082, 647);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErcSystem - Search PDF\'s";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyDown);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.tsMenuRapido.ResumeLayout(false);
            this.tsMenuRapido.PerformLayout();
            this.ssBarraFerramenta.ResumeLayout(false);
            this.ssBarraFerramenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastro;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroPessoa;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
        private System.Windows.Forms.ToolStrip tsMenuRapido;
        private System.Windows.Forms.ToolStripButton tsbtCadastroPessoa;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtSair;
        private System.Windows.Forms.StatusStrip ssBarraFerramenta;
        private System.Windows.Forms.ToolStripStatusLabel tsslblDataSource;
        private System.Windows.Forms.ToolStripStatusLabel tsslblInitialCatalog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton tsbtLeituraPdfs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmLeituraPdfs;
        private System.Windows.Forms.ToolStripButton tsbtAjuda;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmAjuda;
        private System.Windows.Forms.ToolStripMenuItem tsmSistema;
        private System.Windows.Forms.ToolStripMenuItem tsmSistemaBackup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtBackup;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroPdf;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtCadastroPdf;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.ToolStripMenuItem tsmSistemaImportarExportar;
    }
}