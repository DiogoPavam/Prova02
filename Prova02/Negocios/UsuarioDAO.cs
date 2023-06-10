using Prova02.Suporte;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Prova02
{
    public class UsuarioDAO : Conexao
    {
        public bool TestarConexao()
        {
            try
            {
                // Tente abrir a conexão com o banco de dados
                conexao.Open();

                // A conexão foi aberta com sucesso
                return true;
            }
            catch (Exception ex)
            {
                // Ocorreu um erro ao abrir a conexão
                // Você pode tratar o erro de acordo com suas necessidades
                Console.WriteLine("Erro ao testar a conexão: " + ex.Message);
                return false;
            }
            finally
            {
                // Certifique-se de fechar a conexão, mesmo se ocorrer um erro
                conexao.Close();
            }
        }

    }
}
