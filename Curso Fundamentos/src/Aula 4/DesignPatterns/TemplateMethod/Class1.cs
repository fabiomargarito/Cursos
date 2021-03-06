﻿using System;
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
            
            //passo 1
            var conexao = ObterConexao();
                     
            //passo 2   
            DefinirComando();

            //passo 3
            retorno = ExecutarComando();
            
            //passo 4
            retorno = TratarRetorno();

            //passo 5
            FecharConexao();


            return retorno;

        }
    }

    public class DALBlog:DALBase<BLOG>
    {
        protected override void DefinirComando()
        {
            Console.WriteLine("select * from tb_blog");
        }

        protected override List<BLOG> TratarRetorno()
        {
            IList<BLOG> blogs = new List<BLOG>();
            return (List<BLOG>) blogs;
        }
    }

    public class BLOG
    {
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

    public class DALCorretora : DALBase<Corretora>
    {
        protected override void DefinirComando()
        {
            _comando = "select * from corretora";
            Console.WriteLine("Definindo o comando {0}",_comando);
        }

        protected override List<Corretora> TratarRetorno()
        {
            var corretoras= new List<Corretora>
            {
                new Corretora {CNPJ = "0001", Nome = "CPTO"},
                new Corretora {CNPJ = "0002", Nome = "XPTO"}
            };
            System.Console.WriteLine("Retornando Corretoras");
            return corretoras;
        }
    }

    public class DALPaciente:DALBase<Paciente>
    {
        protected override void DefinirComando()
        {
            Console.WriteLine("select * from paciente");
        }

        protected override List<Paciente> TratarRetorno()
        {
            List<Paciente> pacientes = new List<Paciente>();
            pacientes.Add(new Paciente{nome = "fabio",sobrenome = "Margarito"});

            return pacientes;
        }
    }

    public class Paciente
    {
        public string nome { get; set; }
        public string sobrenome { get; set; }
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

    public class Corretora
    {
        public string CNPJ { get; set; }
        public string Nome { get; set; }
    }
}
