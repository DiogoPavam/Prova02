using System.Windows.Forms;

namespace Prova02
{
    partial class Form1
    {

        public DataGridView DataGridViewProdutos => listaDataGridView;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listaDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaidColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedoridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeLabel = new System.Windows.Forms.Label();
            this.produtosLabel = new System.Windows.Forms.Label();
            this.principalMenuStrip = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fazerLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasemcascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentohorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoverticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladoaladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.imprimirButton = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaDataGridView)).BeginInit();
            this.principalMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaDataGridView
            // 
            this.listaDataGridView.AllowUserToAddRows = false;
            this.listaDataGridView.AllowUserToDeleteRows = false;
            this.listaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nomeColumn,
            this.quantidadeColumn,
            this.descricaoColumn,
            this.categoriaidColumn,
            this.fornecedoridColumn});
            this.listaDataGridView.Location = new System.Drawing.Point(12, 77);
            this.listaDataGridView.Name = "listaDataGridView";
            this.listaDataGridView.ReadOnly = true;
            this.listaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaDataGridView.Size = new System.Drawing.Size(776, 332);
            this.listaDataGridView.TabIndex = 6;
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "ID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // nomeColumn
            // 
            this.nomeColumn.DataPropertyName = "Nome";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nomeColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nomeColumn.HeaderText = "Nome";
            this.nomeColumn.Name = "nomeColumn";
            this.nomeColumn.ReadOnly = true;
            // 
            // quantidadeColumn
            // 
            this.quantidadeColumn.DataPropertyName = "Quantidade";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantidadeColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantidadeColumn.HeaderText = "Quantidade";
            this.quantidadeColumn.Name = "quantidadeColumn";
            this.quantidadeColumn.ReadOnly = true;
            // 
            // descricaoColumn
            // 
            this.descricaoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoColumn.DataPropertyName = "Descricao";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.descricaoColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.descricaoColumn.HeaderText = "Descricao";
            this.descricaoColumn.Name = "descricaoColumn";
            this.descricaoColumn.ReadOnly = true;
            // 
            // categoriaidColumn
            // 
            this.categoriaidColumn.DataPropertyName = "Categoria";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.categoriaidColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.categoriaidColumn.HeaderText = "Categoria";
            this.categoriaidColumn.Name = "categoriaidColumn";
            this.categoriaidColumn.ReadOnly = true;
            // 
            // fornecedoridColumn
            // 
            this.fornecedoridColumn.DataPropertyName = "Fornecedor";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fornecedoridColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.fornecedoridColumn.HeaderText = "Fornecedor";
            this.fornecedoridColumn.Name = "fornecedoridColumn";
            this.fornecedoridColumn.ReadOnly = true;
            // 
            // quantidadeLabel
            // 
            this.quantidadeLabel.AutoSize = true;
            this.quantidadeLabel.Location = new System.Drawing.Point(9, 425);
            this.quantidadeLabel.Name = "quantidadeLabel";
            this.quantidadeLabel.Size = new System.Drawing.Size(62, 13);
            this.quantidadeLabel.TabIndex = 7;
            this.quantidadeLabel.Text = "Quantidade";
            // 
            // produtosLabel
            // 
            this.produtosLabel.AutoSize = true;
            this.produtosLabel.Location = new System.Drawing.Point(12, 53);
            this.produtosLabel.Name = "produtosLabel";
            this.produtosLabel.Size = new System.Drawing.Size(49, 13);
            this.produtosLabel.TabIndex = 8;
            this.produtosLabel.Text = "Produtos";
            this.produtosLabel.Click += new System.EventHandler(this.produtosLabel_Click);
            // 
            // principalMenuStrip
            // 
            this.principalMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.exibirToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.principalMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.principalMenuStrip.Name = "principalMenuStrip";
            this.principalMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.principalMenuStrip.TabIndex = 9;
            this.principalMenuStrip.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharToolStripMenuItem,
            this.toolStripSeparator1,
            this.fazerLoginToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // fazerLoginToolStripMenuItem
            // 
            this.fazerLoginToolStripMenuItem.Name = "fazerLoginToolStripMenuItem";
            this.fazerLoginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fazerLoginToolStripMenuItem.Text = "Fazer Login";
            this.fazerLoginToolStripMenuItem.Click += new System.EventHandler(this.fazerLoginToolStripMenuItem_Click_1);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem,
            this.toolStripSeparator2,
            this.usuarioToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuarioToolStripMenuItem.Text = "Usuário";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.janelasemcascataToolStripMenuItem,
            this.alinhamentohorizontalToolStripMenuItem,
            this.alinhamentoverticalToolStripMenuItem,
            this.ladoaladoToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // janelasemcascataToolStripMenuItem
            // 
            this.janelasemcascataToolStripMenuItem.Name = "janelasemcascataToolStripMenuItem";
            this.janelasemcascataToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.janelasemcascataToolStripMenuItem.Text = "Janelas em Cascata";
            this.janelasemcascataToolStripMenuItem.Click += new System.EventHandler(this.janelasemcascataToolStripMenuItem_Click);
            // 
            // alinhamentohorizontalToolStripMenuItem
            // 
            this.alinhamentohorizontalToolStripMenuItem.Name = "alinhamentohorizontalToolStripMenuItem";
            this.alinhamentohorizontalToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.alinhamentohorizontalToolStripMenuItem.Text = "Alinhamento Horizontal";
            this.alinhamentohorizontalToolStripMenuItem.Click += new System.EventHandler(this.alinhamentohorizontalToolStripMenuItem_Click);
            // 
            // alinhamentoverticalToolStripMenuItem
            // 
            this.alinhamentoverticalToolStripMenuItem.Name = "alinhamentoverticalToolStripMenuItem";
            this.alinhamentoverticalToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.alinhamentoverticalToolStripMenuItem.Text = "Alinhamento Vertical";
            this.alinhamentoverticalToolStripMenuItem.Click += new System.EventHandler(this.alinhamentoverticalToolStripMenuItem_Click);
            // 
            // ladoaladoToolStripMenuItem
            // 
            this.ladoaladoToolStripMenuItem.Name = "ladoaladoToolStripMenuItem";
            this.ladoaladoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ladoaladoToolStripMenuItem.Text = "Lado a Lado";
            this.ladoaladoToolStripMenuItem.Click += new System.EventHandler(this.ladoaladoToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // fecharButton
            // 
            this.fecharButton.Image = global::Prova02.Properties.Resources.Excluir;
            this.fecharButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.fecharButton.Location = new System.Drawing.Point(713, 415);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(75, 23);
            this.fecharButton.TabIndex = 5;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // novoButton
            // 
            this.novoButton.Image = global::Prova02.Properties.Resources.Produtos;
            this.novoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.novoButton.Location = new System.Drawing.Point(632, 415);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(75, 23);
            this.novoButton.TabIndex = 4;
            this.novoButton.Text = "Novo";
            this.novoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click_1);
            // 
            // alterarButton
            // 
            this.alterarButton.Image = global::Prova02.Properties.Resources.Config;
            this.alterarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.alterarButton.Location = new System.Drawing.Point(551, 415);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(75, 23);
            this.alterarButton.TabIndex = 3;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Image = global::Prova02.Properties.Resources.Excluir2;
            this.excluirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.excluirButton.Location = new System.Drawing.Point(470, 415);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 2;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // imprimirButton
            // 
            this.imprimirButton.Image = global::Prova02.Properties.Resources.Imprimir1;
            this.imprimirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imprimirButton.Location = new System.Drawing.Point(389, 415);
            this.imprimirButton.Name = "imprimirButton";
            this.imprimirButton.Size = new System.Drawing.Size(75, 23);
            this.imprimirButton.TabIndex = 1;
            this.imprimirButton.Text = "Imprimir";
            this.imprimirButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imprimirButton.UseVisualStyleBackColor = true;
            this.imprimirButton.Click += new System.EventHandler(this.imprimirButton_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.Image = global::Prova02.Properties.Resources.Buscar1;
            this.buscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarButton.Location = new System.Drawing.Point(67, 48);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 0;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.produtosLabel);
            this.Controls.Add(this.quantidadeLabel);
            this.Controls.Add(this.listaDataGridView);
            this.Controls.Add(this.fecharButton);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.alterarButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.imprimirButton);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.principalMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.principalMenuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaDataGridView)).EndInit();
            this.principalMenuStrip.ResumeLayout(false);
            this.principalMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button imprimirButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.DataGridView listaDataGridView;
        private System.Windows.Forms.Label quantidadeLabel;
        private System.Windows.Forms.Label produtosLabel;
        private System.Windows.Forms.MenuStrip principalMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fazerLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelasemcascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinhamentohorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinhamentoverticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladoaladoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaidColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedoridColumn;
    }
}

