namespace SearchPdf.View
{
    partial class FormArquivosPdf
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArquivosPdf));
            this.lblQtdRegistros_qtd = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblQtdRegistros = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colCaminho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmsGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmRemoverArquivoSelecionado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRemoverTodosArquivosDaGrid = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PanelPrincipal.SuspendLayout();
            this.cmsGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQtdRegistros_qtd
            // 
            this.lblQtdRegistros_qtd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQtdRegistros_qtd.AutoSize = true;
            this.lblQtdRegistros_qtd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdRegistros_qtd.Location = new System.Drawing.Point(171, 436);
            this.lblQtdRegistros_qtd.Name = "lblQtdRegistros_qtd";
            this.lblQtdRegistros_qtd.Size = new System.Drawing.Size(16, 18);
            this.lblQtdRegistros_qtd.TabIndex = 12;
            this.lblQtdRegistros_qtd.Text = "0";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(61, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(499, 25);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(4, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 17);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblQtdRegistros
            // 
            this.lblQtdRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQtdRegistros.AutoSize = true;
            this.lblQtdRegistros.Location = new System.Drawing.Point(22, 436);
            this.lblQtdRegistros.Name = "lblQtdRegistros";
            this.lblQtdRegistros.Size = new System.Drawing.Size(143, 17);
            this.lblQtdRegistros.TabIndex = 10;
            this.lblQtdRegistros.Text = "Total de Registro(s): ";
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
            this.colCaminho,
            this.colNome});
            this.dataGridView1.ContextMenuStrip = this.cmsGrid;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(7, 37);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(553, 341);
            this.dataGridView1.TabIndex = 4;
            // 
            // colCaminho
            // 
            this.colCaminho.DataPropertyName = "Caminho";
            this.colCaminho.HeaderText = "Caminho";
            this.colCaminho.Name = "colCaminho";
            this.colCaminho.Visible = false;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colNome.DataPropertyName = "Nome";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNome.Width = 550;
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPrincipal.BackColor = System.Drawing.Color.White;
            this.PanelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelPrincipal.Controls.Add(this.dataGridView1);
            this.PanelPrincipal.Controls.Add(this.txtNome);
            this.PanelPrincipal.Controls.Add(this.lblNome);
            this.PanelPrincipal.Location = new System.Drawing.Point(16, 44);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(574, 389);
            this.PanelPrincipal.TabIndex = 9;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(176, 6);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(134, 31);
            this.btnNovo.TabIndex = 11;
            this.btnNovo.Text = "Novo  F9";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(316, 6);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(134, 31);
            this.btnPesquisar.TabIndex = 13;
            this.btnPesquisar.Text = "Pesquisar  F3";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(456, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(134, 31);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "Fechar  ESC";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(139, 24);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Arquivos PDF";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmsGrid
            // 
            this.cmsGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRemoverArquivoSelecionado,
            this.tsmRemoverTodosArquivosDaGrid});
            this.cmsGrid.Name = "cmsGrid";
            this.cmsGrid.Size = new System.Drawing.Size(248, 70);
            // 
            // tsmRemoverArquivoSelecionado
            // 
            this.tsmRemoverArquivoSelecionado.Image = ((System.Drawing.Image)(resources.GetObject("tsmRemoverArquivoSelecionado.Image")));
            this.tsmRemoverArquivoSelecionado.Name = "tsmRemoverArquivoSelecionado";
            this.tsmRemoverArquivoSelecionado.Size = new System.Drawing.Size(247, 22);
            this.tsmRemoverArquivoSelecionado.Text = "Remover Arquivo Selecionado";
            this.tsmRemoverArquivoSelecionado.Click += new System.EventHandler(this.tsmRemoverArquivoSelecionado_Click);
            // 
            // tsmRemoverTodosArquivosDaGrid
            // 
            this.tsmRemoverTodosArquivosDaGrid.Image = ((System.Drawing.Image)(resources.GetObject("tsmRemoverTodosArquivosDaGrid.Image")));
            this.tsmRemoverTodosArquivosDaGrid.Name = "tsmRemoverTodosArquivosDaGrid";
            this.tsmRemoverTodosArquivosDaGrid.Size = new System.Drawing.Size(247, 22);
            this.tsmRemoverTodosArquivosDaGrid.Text = "Remover Todos Arquivos da Grid";
            this.tsmRemoverTodosArquivosDaGrid.Click += new System.EventHandler(this.tsmRemoverTodosArquivosDaGrid_Click);
            // 
            // FormArquivosPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 460);
            this.Controls.Add(this.lblQtdRegistros_qtd);
            this.Controls.Add(this.lblQtdRegistros);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormArquivosPdf";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "002 - Arquivos PDF";
            this.Load += new System.EventHandler(this.FormArquivosPdf_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormArquivosPdf_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            this.cmsGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQtdRegistros_qtd;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblQtdRegistros;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaminho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip cmsGrid;
        private System.Windows.Forms.ToolStripMenuItem tsmRemoverArquivoSelecionado;
        private System.Windows.Forms.ToolStripMenuItem tsmRemoverTodosArquivosDaGrid;
    }
}