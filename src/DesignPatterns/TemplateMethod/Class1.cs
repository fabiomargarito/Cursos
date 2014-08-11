using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    //Abstract Class
    public abstract class DALBase<T>
    {
        protected string _comando;
        
        protected SqlConnection ObterConexao()
        {
            System.Console.WriteLine("Obtendo Conexao");
            System.Console.WriteLine("Abrindo Conexao");
            return  new SqlConnection();
        }
        protected List<T> ExecutarComando()
        {
            System.Console.WriteLine("Executando o comando {0}", _comando);
            return new List<T>();
        }
        
        protected abstract void DefinirComando();
        protected abstract List<T> TratarRetorno();
        
        protected  void FecharConexao()
        {
            System.Console.WriteLine("Fechando Conexao");
        }

        //Template Method
        public List<T> Executar()
        {
            List<T> retorno;
            
            var conexao = ObterConexao();
                        
            DefinirComando();
            
            retorno = TratarRetorno();

            FecharConexao();


            return retorno;

        }
    }

    

    public class DALCliente : DALBase<Cliente>
    {
        protected override void DefinirComando()
        {
            _comando = "select * from cliente";
            System.Console.WriteLine("Definindo o comando {0}",_comando);
            
        }

        protected override List<Cliente> TratarRetorno()
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(new Cliente{cpf = "2222222"});
            return clientes;
        }
    }
















    public class DALFornecedor : DALBase<Fornecedor>
    {
        protected override void DefinirComando()
        {
            _comando = "select * from fornecedor";
        }

        protected override List<Fornecedor> TratarRetorno()
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();
            fornecedores.Add(new Fornecedor { cnpj = "2222222" });
            return fornecedores;
        }
    }

    public class DALACAO:DALBase<Acao>
    {
        protected override void DefinirComando()
        {
            _comando = "select codigo from tbAcao";
            System.Console.WriteLine("Definindo o comando {0}", _comando);
        }

        protected override List<Acao> TratarRetorno()
        {
            List<Acao> acoes = new List<Acao>();
            acoes.Add(new Acao { CODIGO = "PETR4" });
            System.Console.WriteLine("Retornando Acoes");
            return acoes;
        }
    }


    public class Acao
    {
        public string CODIGO { get; set; }
    }

    public class Cliente
    {
        public string cpf { get; set; }
    }

    public class Fornecedor
    {
        public string cnpj { get; set; }
    }
}
