using Dapper;
using System.Data;
using System.Data.SqlClient;
using Prova02;


namespace Prova02
{
    public class UsuariosDAO
    {
        string textoConexao = "Server=(local)\\SQLEXPRESS;Database=ControleEstoque;Trusted_Connection=True;";

        /// <summary>
        /// Método que realiza o login.
        /// </summary>
        /// <param name="login">Login do usuário</param>
        /// <param name="senha">Senha do usuário</param>
        /// <returns>Retorna um usuário ou null caso não encontre</returns>
        public Usuario Login(string login, string senha)
        {
            using (SqlConnection connection = new SqlConnection(textoConexao))
            {
                string sql = "SELECT * FROM Usuarios WHERE Login=@pLogin AND Senha=@pSenha";
                return connection.QueryFirstOrDefault<Usuario>(sql, new { pLogin = login, pSenha = senha });
            }
        }
    }
}
