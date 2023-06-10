using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Prova02
{
    public class ProdutoDAO
    {
        private string connectionString;

        public ProdutoDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Produto> BuscarProdutos()
        {
            string connectionString = "Server=(local)\\SQLEXPRESS;Database=ControleEstoque;Trusted_Connection=True;";
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM Produtos";
                return conexao.Query<Produto>(sql).ToList();
            }

        }

        public void InserirProduto(Produto produto)
        {
            using (SqlConnection conexao = new SqlConnection("Server = (local)\\SQLEXPRESS; Database = ControleEstoque; Trusted_Connection = True; "))
            {
                string sql = "INSERT INTO Produtos (Nome, Descricao, Quantidade, Categoria, Fornecedor) " +
                             "VALUES (@Nome, @Descricao, @Quantidade, @Categoria, @Fornecedor)";

                var parametros = new
                {
                    Nome = produto.Nome,
                    Descricao = produto.Descricao,
                    Quantidade = produto.Quantidade,
                    Categoria = produto.Categoria,
                    Fornecedor = produto.Fornecedor
                };

                conexao.Execute(sql, parametros);
            }
        }

        public void AtualizarProduto(Produto produto)
        {
            using (SqlConnection conexao = new SqlConnection("Server=(local)\\SQLEXPRESS;Database=ControleEstoque;Trusted_Connection=True;"))
            {
                string sql = "UPDATE Produtos SET Nome = @Nome, Descricao = @Descricao, " +
                             "Quantidade = @Quantidade, Categoria = @Categoria, Fornecedor = @Fornecedor " +
                             "WHERE ID = @ID";

                conexao.Execute(sql, new
                {
                    ID = produto.ID,
                    Nome = produto.Nome,
                    Descricao = produto.Descricao,
                    Quantidade = produto.Quantidade,
                    Categoria = produto.Categoria,
                    Fornecedor = produto.Fornecedor
                });
            }
        }

        public void ExcluirProduto(int produtoId)
        {
            using (SqlConnection conexao = new SqlConnection("Server = (local)\\SQLEXPRESS; Database = ControleEstoque; Trusted_Connection = True; "))
            {
                string sql = "DELETE FROM Produtos WHERE ID = @ID";

                var parametros = new { ID = produtoId };

                conexao.Execute(sql, parametros);
            }
        }
    }
}
