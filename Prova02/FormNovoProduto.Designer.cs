namespace Prova02
{
    partial class FormNovoProduto
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
            this.nomeLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeLabel = new System.Windows.Forms.Label();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoLabel = new System.Windows.Forms.Label();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            this.quantidadeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.categoriaLabel = new System.Windows.Forms.Label();
            this.fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.fornecedorLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(12, 23);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(35, 13);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Nome";
            //this.nomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(12, 39);
            this.nomeTextBox.MaxLength = 100;
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(287, 20);
            this.nomeTextBox.TabIndex = 1;
            // 
            // quantidadeLabel
            // 
            this.quantidadeLabel.AutoSize = true;
            this.quantidadeLabel.Location = new System.Drawing.Point(9, 63);
            this.quantidadeLabel.Name = "quantidadeLabel";
            this.quantidadeLabel.Size = new System.Drawing.Size(62, 13);
            this.quantidadeLabel.TabIndex = 2;
            this.quantidadeLabel.Text = "Quantidade";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(12, 118);
            this.descricaoTextBox.MaxLength = 200;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(287, 20);
            this.descricaoTextBox.TabIndex = 5;
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.AutoSize = true;
            this.descricaoLabel.Location = new System.Drawing.Point(9, 102);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(55, 13);
            this.descricaoLabel.TabIndex = 4;
            this.descricaoLabel.Text = "Descrição";
            //this.descricaoLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(364, 281);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 6;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(283, 281);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 7;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // quantidadeNumericUpDown
            // 
            this.quantidadeNumericUpDown.Location = new System.Drawing.Point(12, 79);
            this.quantidadeNumericUpDown.Name = "quantidadeNumericUpDown";
            this.quantidadeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.quantidadeNumericUpDown.TabIndex = 8;
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.Location = new System.Drawing.Point(12, 163);
            this.categoriaTextBox.MaxLength = 200;
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(287, 20);
            this.categoriaTextBox.TabIndex = 10;
            //this.categoriaTextBox.TextChanged += new System.EventHandler(this.categoriaidTextBox_TextChanged);
            // 
            // categoriaLabel
            // 
            this.categoriaLabel.AutoSize = true;
            this.categoriaLabel.Location = new System.Drawing.Point(9, 147);
            this.categoriaLabel.Name = "categoriaLabel";
            this.categoriaLabel.Size = new System.Drawing.Size(52, 13);
            this.categoriaLabel.TabIndex = 9;
            this.categoriaLabel.Text = "Categoria";
            // 
            // fornecedorTextBox
            // 
            this.fornecedorTextBox.Location = new System.Drawing.Point(12, 209);
            this.fornecedorTextBox.MaxLength = 200;
            this.fornecedorTextBox.Name = "fornecedorTextBox";
            this.fornecedorTextBox.Size = new System.Drawing.Size(287, 20);
            this.fornecedorTextBox.TabIndex = 12;
            // 
            // fornecedorLabel
            // 
            this.fornecedorLabel.AutoSize = true;
            this.fornecedorLabel.Location = new System.Drawing.Point(9, 193);
            this.fornecedorLabel.Name = "fornecedorLabel";
            this.fornecedorLabel.Size = new System.Drawing.Size(55, 13);
            this.fornecedorLabel.TabIndex = 11;
            this.fornecedorLabel.Text = "Forncedor";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormNovoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 316);
            this.Controls.Add(this.fornecedorTextBox);
            this.Controls.Add(this.fornecedorLabel);
            this.Controls.Add(this.categoriaTextBox);
            this.Controls.Add(this.categoriaLabel);
            this.Controls.Add(this.quantidadeNumericUpDown);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.descricaoLabel);
            this.Controls.Add(this.quantidadeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.nomeLabel);
            this.Name = "FormNovoProduto";
            this.Text = "FormNovoProduto";
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label quantidadeLabel;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Label descricaoLabel;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.NumericUpDown quantidadeNumericUpDown;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.Label categoriaLabel;
        private System.Windows.Forms.TextBox fornecedorTextBox;
        private System.Windows.Forms.Label fornecedorLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}