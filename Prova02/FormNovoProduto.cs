using System;
using System.Windows.Forms;

namespace Prova02
{
    public partial class FormNovoProduto : Form
    {
        private string connectionString;

        public FormNovoProduto(int id, string nome, string descricao, int quantidade, string categoria, string fornecedor, string connectionString)
        {
            InitializeComponent();
            Produto produto = new Produto(id, nome, descricao, quantidade, categoria, fornecedor);
            this.connectionString = connectionString;
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            string nome = nomeTextBox.Text;
            string descricao = descricaoTextBox.Text;
            int quantidade = Convert.ToInt32(quantidadeNumericUpDown.Value);
            string categoria = categoriaTextBox.Text;
            string fornecedor = fornecedorTextBox.Text;

            // Criar objeto Produto com os dados inseridos
            Produto novoProduto = new Produto(0, nome, descricao, quantidade, categoria, fornecedor);

            try
            {
                // Inserir o novo produto no banco de dados usando o seu DAO
                ProdutoDAO produtoDAO = new ProdutoDAO(connectionString);
                produtoDAO.InserirProduto(novoProduto);

                // Exibir uma mensagem de sucesso ou realizar outras ações necessárias
                MessageBox.Show("Produto inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Fechar o formulário de inserção
                this.Close();
            }
            catch (Exception ex)
            {
                // Tratar exceções ou exibir uma mensagem de erro adequada
                MessageBox.Show("Erro ao inserir o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
