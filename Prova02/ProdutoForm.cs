using System;
using System.Windows.Forms;

namespace Prova02
{
    public partial class ProdutoForm : Form
    {
        private TextBox fornecedorTextBox;
        private Label fornecedorLabel;
        private TextBox categoriaTextBox;
        private Label categoriaLabel;
        private NumericUpDown quantidadeNumericUpDown;
        private Button salvarButton;
        private Button cancelarButton;
        private TextBox descricaoTextBox;
        private Label descricaoLabel;
        private Label quantidadeLabel;
        private TextBox nomeTextBox;
        private Label nomeLabel;

        private FormPrincipal formPrincipal;
        private string connectionString;

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public string Categoria { get; set; }
        public string Fornecedor { get; set; }

        public ProdutoForm(int id, string nome, string descricao, int quantidade, string categoria, string fornecedor, string connectionString, FormPrincipal formPrincipal)
        {
            InitializeComponent();
            Produto = new Produto(id, nome, descricao, quantidade, categoria, fornecedor);
            this.connectionString = connectionString;
            this.formPrincipal = formPrincipal;
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            string nome = nomeTextBox.Text;
            string descricao = descricaoTextBox.Text;
            int quantidade = Convert.ToInt32(quantidadeNumericUpDown.Value);
            string categoria = categoriaTextBox.Text;
            string fornecedor = fornecedorTextBox.Text;

            // Criar objeto Produto com os dados atualizados
            Produto produtoAtualizado = new Produto(Produto.ID, nome, descricao, quantidade, categoria, fornecedor);

            try
            {
                // Atualizar o produto no banco de dados usando o seu DAO
                ProdutoDAO produtoDAO = new ProdutoDAO(connectionString);
                produtoDAO.AtualizarProduto(produtoAtualizado);

                // Exibir uma mensagem de sucesso ou realizar outras ações necessárias
                MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Fechar o formulário de alteração e atualizar a exibição dos produtos no formulário principal
                this.Close();
                formPrincipal.AtualizarExibicaoProdutosFormPrincipal();
            }
            catch (Exception ex)
            {
                // Tratar exceções ou exibir uma mensagem de erro adequada
                MessageBox.Show("Erro ao atualizar o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Restante do código do ProdutoForm...

        private Produto Produto { get; set; }

        private void InitializeComponent()
        {
            this.fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.fornecedorLabel = new System.Windows.Forms.Label();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.categoriaLabel = new System.Windows.Forms.Label();
            this.quantidadeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.salvarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoLabel = new System.Windows.Forms.Label();
            this.quantidadeLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // fornecedorTextBox
            // 
            this.fornecedorTextBox.Location = new System.Drawing.Point(127, 197);
            this.fornecedorTextBox.Name = "fornecedorTextBox";
            this.fornecedorTextBox.Size = new System.Drawing.Size(200, 20);
            this.fornecedorTextBox.TabIndex = 11;
            // 
            // fornecedorLabel
            // 
            this.fornecedorLabel.AutoSize = true;
            this.fornecedorLabel.Location = new System.Drawing.Point(36, 200);
            this.fornecedorLabel.Name = "fornecedorLabel";
            this.fornecedorLabel.Size = new System.Drawing.Size(63, 13);
            this.fornecedorLabel.TabIndex = 10;
            this.fornecedorLabel.Text = "Fornecedor";
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.Location = new System.Drawing.Point(127, 159);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(200, 20);
            this.categoriaTextBox.TabIndex = 9;
            // 
            // categoriaLabel
            // 
            this.categoriaLabel.AutoSize = true;
            this.categoriaLabel.Location = new System.Drawing.Point(36, 162);
            this.categoriaLabel.Name = "categoriaLabel";
            this.categoriaLabel.Size = new System.Drawing.Size(52, 13);
            this.categoriaLabel.TabIndex = 8;
            this.categoriaLabel.Text = "Categoria";
            // 
            // quantidadeNumericUpDown
            // 
            this.quantidadeNumericUpDown.Location = new System.Drawing.Point(127, 121);
            this.quantidadeNumericUpDown.Name = "quantidadeNumericUpDown";
            this.quantidadeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.quantidadeNumericUpDown.TabIndex = 7;
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(127, 245);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 13;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(252, 245);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 14;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(127, 83);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(200, 20);
            this.descricaoTextBox.TabIndex = 5;
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.AutoSize = true;
            this.descricaoLabel.Location = new System.Drawing.Point(36, 86);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(58, 13);
            this.descricaoLabel.TabIndex = 4;
            this.descricaoLabel.Text = "Descrição:";
            // 
            // quantidadeLabel
            // 
            this.quantidadeLabel.AutoSize = true;
            this.quantidadeLabel.Location = new System.Drawing.Point(36, 123);
            this.quantidadeLabel.Name = "quantidadeLabel";
            this.quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            this.quantidadeLabel.TabIndex = 6;
            this.quantidadeLabel.Text = "Quantidade:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(127, 45);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 3;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(36, 48);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 2;
            this.nomeLabel.Text = "Nome:";
            // 
            // ProdutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 303);
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
            this.Name = "ProdutoForm";
            this.Text = "Formulário de Produto";
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
