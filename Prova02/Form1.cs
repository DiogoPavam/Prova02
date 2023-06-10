using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace Prova02
{
    public partial class Form1 : Form
    {    
        public void AtualizarExibicaoProdutosFormPrincipal()
        {
            // Realize as ações necessárias para atualizar a exibição dos produtos no formulário principal
            // Por exemplo, você pode chamar o método BuscarProdutos() do ProdutoDAO e atualizar o DataGridView
            ProdutoDAO produtoDAO = new ProdutoDAO("Server=(local)\\SQLEXPRESS;Database=ControleEstoque;Trusted_Connection=True;");
            List<Produto> produtos = produtoDAO.BuscarProdutos();
            listaDataGridView.DataSource = produtos;
        }

        private void FormNovoProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Atualize a exibição dos produtos no formulário principal
            AtualizarExibicaoProdutosFormPrincipal();
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void produtosLabel_Click(object sender, EventArgs e)
        {

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o programa?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                // Cancela o fechamento do formulário
                return;
            }

            // Fecha o aplicativo
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UsuarioDAO dao = new UsuarioDAO();
            bool conexaoOk = dao.TestarConexao();

            if (conexaoOk)
            {
                // A conexão foi estabelecida com sucesso
                MessageBox.Show("Conexão bem-sucedida!");
            }
            else
            {
                // Houve um problema ao estabelecer a conexão
                MessageBox.Show("Falha na conexão.");
            }

        }

        private void janelasemcascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void alinhamentohorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void alinhamentoverticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void ladoaladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            // Realiza a consulta no banco de dados utilizando o Dapper
            string connectionString = "Server = (local)\\SQLEXPRESS; Database = ControleEstoque; Trusted_Connection = True;";
            ProdutoDAO produtoDAO = new ProdutoDAO(connectionString);

            // Execute a consulta SQL utilizando o Dapper e armazene os resultados em uma lista
            List<Produto> produtos = produtoDAO.BuscarProdutos();

            // Exiba os dados no DataGridView
            listaDataGridView.DataSource = produtos;
        }

        private void imprimirButton_Click(object sender, EventArgs e)
        {
            // Realiza a consulta no banco de dados utilizando o Dapper
            string connectionString = "Server = (local)\\SQLEXPRESS; Database = ControleEstoque; Trusted_Connection = True;";
            ProdutoDAO produtoDAO = new ProdutoDAO(connectionString);

            // Execute a consulta SQL utilizando o Dapper e armazene os resultados em uma lista
            List<Produto> produtos = produtoDAO.BuscarProdutos();

            // Exiba a mensagem com os produtos na interface do usuário
            ExibirMensagem(produtos);
        }

        private void ExibirMensagem(List<Produto> produtos)
        {
            // Monta a mensagem com os produtos para exibir na interface do usuário
            string mensagem = "Produtos para impressão:\n";
            foreach (Produto produto in produtos)
            {
                mensagem += $"ID: {produto.ID}, Nome: {produto.Nome}, Descrição: {produto.Descricao}, Quantidade: {produto.Quantidade}\n";
            }

            // Exibe a mensagem em um MessageBox
            MessageBox.Show(mensagem, "Produtos para Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void novoButton_Click_1(object sender, EventArgs e)
        {
            // Crie uma instância do FormNovoProduto
            FormNovoProduto novoProdutoForm = new FormNovoProduto(0, "Nome", "Descrição", 10, "Categoria", "Fornecedor", "Server=(local)\\SQLEXPRESS;Database=ControleEstoque;Trusted_Connection=True;");

            // Exiba o FormNovoProduto
            novoProdutoForm.Show();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            if (listaDataGridView.SelectedRows.Count > 0)
            {
                // Obtém o ID da linha selecionada no grid
                int id = Convert.ToInt32(listaDataGridView.SelectedRows[0].Cells["idColumn"].Value);

                // Conexão com o banco de dados
                string connectionString = "Server=(local)\\SQLEXPRESS;Database=ControleEstoque;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para obter os dados do produto com base no ID
                    string query = "SELECT * FROM Produtos WHERE ID = @ID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Obtém os dados do produto do banco de dados
                        string nome = reader["Nome"].ToString();
                        string descricao = reader["Descricao"].ToString();
                        int quantidade = Convert.ToInt32(reader["Quantidade"]);
                        string categoria = reader["Categoria"].ToString();
                        string fornecedor = reader["Fornecedor"].ToString();

                        FormPrincipal formPrincipal = new FormPrincipal(this);
                        // Cria um novo formulário de edição passando os dados do produto
                        ProdutoForm produtoForm = new ProdutoForm(id, nome, descricao, quantidade, categoria, fornecedor, connectionString, formPrincipal);


                        if (produtoForm.ShowDialog() == DialogResult.OK)
                        {
                            // Atualiza os dados no banco de dados
                            string updateQuery = "UPDATE Produtos SET Nome = @Nome, Descricao = @Descricao, Quantidade = @Quantidade, Categoria = @Categoria, Fornecedor = @Fornecedor WHERE ID = @ID";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                            updateCommand.Parameters.AddWithValue("@ID", id);
                            updateCommand.Parameters.AddWithValue("@Nome", produtoForm.Nome);
                            updateCommand.Parameters.AddWithValue("@Descricao", produtoForm.Descricao);
                            updateCommand.Parameters.AddWithValue("@Quantidade", produtoForm.Quantidade);
                            updateCommand.Parameters.AddWithValue("@Categoria", produtoForm.Categoria);
                            updateCommand.Parameters.AddWithValue("@Fornecedor", produtoForm.Fornecedor);
                            

                            updateCommand.ExecuteNonQuery();

                            MessageBox.Show("Produto atualizado com sucesso!");

                            // Atualiza a exibição dos produtos no formulário principal
                            AtualizarExibicaoProdutosFormPrincipal();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado!");
                    }
                }
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do produto?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (listaDataGridView.SelectedRows.Count > 0)
                {
                    // Pega o ID da linha selecionada no grid
                    int id = Convert.ToInt32(listaDataGridView.SelectedRows[0].Cells["idColumn"].Value);

                    // Executa a exclusão
                    ProdutoDAO produtoDAO = new ProdutoDAO("Server=(local)\\SQLEXPRESS;Database=ControleEstoque;Trusted_Connection=True;");
                    produtoDAO.ExcluirProduto(id);

                    // Executa a busca novamente, como se tivesse clicado no botão
                    buscarButton.PerformClick();

                    // Avisa o usuário
                    MessageBox.Show("Produto excluído com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void fazerLoginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Global.UsuarioLogado = null;
            VerificarLogin();
        }

        void VerificarLogin()
        {
            if (Global.UsuarioLogado == null)
            {
                // fecha os forms abertos
                foreach (Form f in this.MdiChildren)
                    f.Close();
                fazerLoginToolStripMenuItem.Text = "Entrar";

                // chama a tela de login
                new LoginForm().ShowDialog();
            }
            else if (Global.UsuarioLogado != null)
            {
                fazerLoginToolStripMenuItem.Text = "Fazer Logoff";
            }
        }


        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
