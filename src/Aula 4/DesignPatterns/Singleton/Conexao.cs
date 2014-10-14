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

    public class ConexaoBanco
    {
        private static ConexaoBanco _conexao;
        private SqlConnection sqlConnection;
        private string _stringConexao;

        public ConexaoBanco DefinirStringConexao(string stringDeConexao)
        {
            _stringConexao = stringDeConexao;
            return this;
        }

        public SqlConnection RetornarConexao()
        {            
            return new SqlConnection(_stringConexao);
        }

        private ConexaoBanco()
        {
            //Logica para buscar a string de conexao no banco
        }

        public static ConexaoBanco Criar()
        {
            if(_conexao == null)
                return new ConexaoBanco();
            
            return _conexao;
        }
    }






}
