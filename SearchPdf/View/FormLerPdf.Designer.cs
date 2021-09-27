namespace SearchPdf.View
{
    partial class FormLerPdf
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLerPdf));
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.gbPessoasEncontradas = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbTexto = new System.Windows.Forms.GroupBox();
            this.rtxtTexto = new System.Windows.Forms.RichTextBox();
            this.chkProcurarTodos = new System.Windows.Forms.CheckBox();
            this.cbPessoa = new System.Windows.Forms.ComboBox();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.btnLerPdf = new System.Windows.Forms.Button();
            this.cbPdf = new System.Windows.Forms.ComboBox();
            this.lblPdfs = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPessoaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelPrincipal.SuspendLayout();
            this.gbPessoasEncontradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbTexto.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPrincipal.BackColor = System.Drawing.Color.White;
            this.PanelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelPrincipal.Controls.Add(this.btnProcurar);
            this.PanelPrincipal.Controls.Add(this.gbPessoasEncontradas);
            this.PanelPrincipal.Controls.Add(this.gbTexto);
            this.PanelPrincipal.Controls.Add(this.chkProcurarTodos);
            this.PanelPrincipal.Controls.Add(this.cbPessoa);
            this.PanelPrincipal.Controls.Add(this.lblPessoa);
            this.PanelPrincipal.Controls.Add(this.btnLerPdf);
            this.PanelPrincipal.Controls.Add(this.cbPdf);
            this.PanelPrincipal.Controls.Add(this.lblPdfs);
            this.PanelPrincipal.Location = new System.Drawing.Point(16, 44);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1024, 541);
            this.PanelPrincipal.TabIndex = 9;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurar.Location = new System.Drawing.Point(925, 35);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(92, 27);
            this.btnProcurar.TabIndex = 8;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // gbPessoasEncontradas
            // 
            this.gbPessoasEncontradas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPessoasEncontradas.Controls.Add(this.dataGridView1);
            this.gbPessoasEncontradas.Location = new System.Drawing.Point(710, 68);
            this.gbPessoasEncontradas.Name = "gbPessoasEncontradas";
            this.gbPessoasEncontradas.Size = new System.Drawing.Size(307, 466);
            this.gbPessoasEncontradas.TabIndex = 7;
            this.gbPessoasEncontradas.TabStop = false;
            this.gbPessoasEncontradas.Text = "Pessoas Encontradas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNome,
            this.colPessoaId,
            this.colDesativa,
            this.colCadastro});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(295, 435);
            this.dataGridView1.TabIndex = 15;
            // 
            // gbTexto
            // 
            this.gbTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTexto.Controls.Add(this.rtxtTexto);
            this.gbTexto.Location = new System.Drawing.Point(6, 68);
            this.gbTexto.Name = "gbTexto";
            this.gbTexto.Size = new System.Drawing.Size(698, 466);
            this.gbTexto.TabIndex = 6;
            this.gbTexto.TabStop = false;
            this.gbTexto.Text = "Texto";
            // 
            // rtxtTexto
            // 
            this.rtxtTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtTexto.Location = new System.Drawing.Point(7, 25);
            this.rtxtTexto.Name = "rtxtTexto";
            this.rtxtTexto.ReadOnly = true;
            this.rtxtTexto.Size = new System.Drawing.Size(685, 435);
            this.rtxtTexto.TabIndex = 0;
            this.rtxtTexto.Text = "";
            // 
            // chkProcurarTodos
            // 
            this.chkProcurarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkProcurarTodos.AutoSize = true;
            this.chkProcurarTodos.Location = new System.Drawing.Point(710, 39);
            this.chkProcurarTodos.Name = "chkProcurarTodos";
            this.chkProcurarTodos.Size = new System.Drawing.Size(209, 21);
            this.chkProcurarTodos.TabIndex = 5;
            this.chkProcurarTodos.Text = "Procurar Todas as Pessoas";
            this.chkProcurarTodos.UseVisualStyleBackColor = true;
            this.chkProcurarTodos.CheckedChanged += new System.EventHandler(this.chkProcurarTodos_CheckedChanged);
            // 
            // cbPessoa
            // 
            this.cbPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPessoa.DropDownHeight = 55;
            this.cbPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPessoa.FormattingEnabled = true;
            this.cbPessoa.IntegralHeight = false;
            this.cbPessoa.Location = new System.Drawing.Point(71, 37);
            this.cbPessoa.Name = "cbPessoa";
            this.cbPessoa.Size = new System.Drawing.Size(633, 25);
            this.cbPessoa.TabIndex = 4;
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Location = new System.Drawing.Point(3, 40);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(62, 17);
            this.lblPessoa.TabIndex = 3;
            this.lblPessoa.Text = "Pessoa:";
            // 
            // btnLerPdf
            // 
            this.btnLerPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLerPdf.Location = new System.Drawing.Point(925, 4);
            this.btnLerPdf.Name = "btnLerPdf";
            this.btnLerPdf.Size = new System.Drawing.Size(92, 27);
            this.btnLerPdf.TabIndex = 2;
            this.btnLerPdf.Text = "Ler PDF";
            this.btnLerPdf.UseVisualStyleBackColor = true;
            this.btnLerPdf.Click += new System.EventHandler(this.btnLerPdf_Click);
            // 
            // cbPdf
            // 
            this.cbPdf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPdf.DropDownHeight = 55;
            this.cbPdf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPdf.FormattingEnabled = true;
            this.cbPdf.IntegralHeight = false;
            this.cbPdf.Location = new System.Drawing.Point(71, 6);
            this.cbPdf.Name = "cbPdf";
            this.cbPdf.Size = new System.Drawing.Size(848, 25);
            this.cbPdf.TabIndex = 1;
            this.cbPdf.SelectedValueChanged += new System.EventHandler(this.cbPdf_SelectedValueChanged);
            // 
            // lblPdfs
            // 
            this.lblPdfs.AutoSize = true;
            this.lblPdfs.Location = new System.Drawing.Point(23, 9);
            this.lblPdfs.Name = "lblPdfs";
            this.lblPdfs.Size = new System.Drawing.Size(42, 17);
            this.lblPdfs.TabIndex = 0;
            this.lblPdfs.Text = "PDF:";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(906, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(134, 31);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "Fechar  ESC";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 24);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Leitura de PDF\'s";
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNome.DataPropertyName = "Nome";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colPessoaId
            // 
            this.colPessoaId.DataPropertyName = "PessoaId";
            this.colPessoaId.HeaderText = "PessoaId";
            this.colPessoaId.Name = "colPessoaId";
            this.colPessoaId.Visible = false;
            // 
            // colDesativa
            // 
            this.colDesativa.DataPropertyName = "Desativa";
            this.colDesativa.HeaderText = "Desativa";
            this.colDesativa.Name = "colDesativa";
            this.colDesativa.Visible = false;
            // 
            // colCadastro
            // 
            this.colCadastro.DataPropertyName = "Cadastro";
            this.colCadastro.HeaderText = "Cadastro";
            this.colCadastro.Name = "colCadastro";
            this.colCadastro.Visible = false;
            // 
            // FormLerPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 597);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1068, 636);
            this.Name = "FormLerPdf";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "003 - Leitura de PDF\'s";
            this.Load += new System.EventHandler(this.FormLerPdf_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLerPdf_KeyDown);
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            this.gbPessoasEncontradas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbTexto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPdfs;
        private System.Windows.Forms.ComboBox cbPdf;
        private System.Windows.Forms.Button btnLerPdf;
        private System.Windows.Forms.Label lblPessoa;
        private System.Windows.Forms.ComboBox cbPessoa;
        private System.Windows.Forms.CheckBox chkProcurarTodos;
        private System.Windows.Forms.GroupBox gbTexto;
        private System.Windows.Forms.GroupBox gbPessoasEncontradas;
        private System.Windows.Forms.RichTextBox rtxtTexto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPessoaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCadastro;
    }
}