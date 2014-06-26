using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace AplicacaoParaRefactoringCompraEVendaDeAcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente();
            cliente.CPF = "123.133.132-23";
            cliente.Nome = "Cliente de teste";

            //gravando operacao de compra na carteira
            var acao = new Acao {Codigo = "PETR4", PrAcao = 10, Quantidade = 12};
            var corretora = new Corretora();
            corretora.RegistrarCompraAcao(acao, cliente);


            //gravando operacao de compra na carteira
            Acao acao2 = new Acao();
            acao2.Codigo = "PETR3";
            acao2.PrAcao = 10;
            acao2.Quantidade = 12;
            
            corretora.RegistrarVendaAcao(acao2, cliente);

            //Mostrando a Carteira
            DalCarteira carteira = new DalCarteira();
            foreach (var cart in carteira.RetornCarteiras(cliente))
            {
                Console.WriteLine("ACAO:{0}          VAlor:{1}      Quantidade:{2}    ValorTotal:{3}    ",cart.Acao.Codigo,cart.Acao.PrAcao,cart.Acao.Quantidade,cart.Acao.CustoOperacao);
            }
            Console.ReadKey();

        }
    }



    
    //domínio amarrado com infraestrutura
    public class Cliente
    {
        public string CPF { get; set; }
        public string Nome { get; set; }    
        
        public Boolean Gravar()
        {
            new RepositorioCliente().Gravar(this);
            return true;
        }  
    }


    public class ServicoDeCliente
    {
        private RepositorioCliente _repositorioClienteCliente;
        public ServicoDeCliente(RepositorioCliente repositorioCliente)
        {
            _repositorioClienteCliente = repositorioCliente;
        }

        public Boolean GravarCliente(Cliente cliente)
        {   
            return _repositorioClienteCliente.Gravar(cliente);
        }
    }


    public class RepositorioCliente
    {
        public Boolean Gravar(Cliente cliente)
        {
            Console.WriteLine("Cliente Gravado");
            return true;
        }
    }


    public class Acao
    {
        public string Codigo;
        public int Quantidade;
       
        //estranho ação ter o valor. Cotacao Deveria ter o Valor
        public double Valor;
        public double CustoOperacao;
                
        //Preco Da Acao
        public double PrAcao;

        
        private Acao RetornarCotacao(string cdAcao)
        {
            //simulando acesso ao banco
            return new Acao{Codigo = cdAcao,Valor = 10};
        }
        

    }
   

    public class Carteira
    {
        //carteira deveria ter conjunto de operacoes
        public Acao Acao;
        public double vlRentabilidade;
        public Cliente Cliente;
        public int TipoOperacao;

    }

    public class DalCarteira
    {        
        public void gravar(Carteira carteira)
        {                        

            DataSet dataSet = new DataSet();

            
            DataTable dataTable;
            if (!File.Exists("carteira.xml"))
            {
                dataTable = new DataTable("carteira");

                dataTable.Columns.Add("Acao");
                dataTable.Columns.Add("Valor");
                dataTable.Columns.Add("Quantidade");
                dataTable.Columns.Add("ValorTotal");

                dataTable.Rows.Add(carteira.Acao.Codigo, carteira.Acao.PrAcao, carteira.Acao.Quantidade,
                carteira.Acao.CustoOperacao);

                dataSet.Tables.Add(dataTable);
            }
            else
            {
                dataSet.ReadXml("carteira.xml");
                dataTable = dataSet.Tables["carteira"];
                dataTable.Rows.Add(carteira.Acao.Codigo, carteira.Acao.PrAcao, carteira.Acao.Quantidade,
                carteira.Acao.CustoOperacao);
            }
                     
            
            dataSet.WriteXml("carteira.xml");

        }

        public List<Carteira> RetornCarteiras(Cliente cliente)
        {
            var operacoes = new List<Carteira>();
            DataSet dataset = new DataSet();

            

            dataset.ReadXml("carteira.xml");

            foreach (DataRow row in dataset.Tables[0].Rows)
            {
               operacoes.Add( new Carteira
                {
                    Acao = new Acao {Codigo = row[0].ToString(), PrAcao = Convert.ToDouble(row[1]), Quantidade = Convert.ToInt16(row[2]), CustoOperacao = Convert.ToDouble(row[3])}

                });
            }
            return operacoes;
        }

    }
}
