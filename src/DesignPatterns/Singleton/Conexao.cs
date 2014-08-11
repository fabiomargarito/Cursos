using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Singleton
{
    public class Conexao
    {
        private static Conexao _instanciaConexao;
        
        private SqlConnection _sqlConnection;
        
        private Conexao()
        {            
        }

        public static Conexao CriarConexao()
        {
            if (_instanciaConexao == null)
            {
                _instanciaConexao = new Conexao();
                _instanciaConexao._sqlConnection = new SqlConnection();
            }

            return _instanciaConexao;
        }

        public SqlConnection RetornarConexao()
        {
            return _sqlConnection;
        }
    }



    public class ConexaoModelo2
    {
        private static SqlConnection _instanciaConexao;        

        private ConexaoModelo2()
        {
        }

        public static SqlConnection RetornarConexao()
        {
            if (_instanciaConexao == null)
            {
                _instanciaConexao = new SqlConnection();                
            }

            return _instanciaConexao;
        }
        
    }
}
