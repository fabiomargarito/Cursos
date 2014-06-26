using System.Data.SqlClient;

namespace SingletonConexao
{
    public class Conexao
    {
        private static SqlConnection _connection;

        private Conexao()
        {
        }

        public static SqlConnection RetornarConexao()
        {
            if (_connection == null)
            {
                _connection = new SqlConnection();
            }
 
            return _connection;
        }
    }
}
