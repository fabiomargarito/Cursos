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
            var cliente = new Cliente("123.133.132-23","Cliente de teste");
            

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
            DalOperacao carteira = new DalOperacao();
            foreach (var cart in carteira.RetornarOperacoes(cliente))
            {
                Console.WriteLine("ACAO:{0}          VAlor:{1}      Quantidade:{2}    ValorTotal:{3}    ",cart.Acao.Codigo,cart.Acao.PrAcao,cart.Acao.Quantidade,cart.Acao.CustoOperacao);
            }
            Console.ReadKey();

        }
    }



    
    //domínio amarrado com infraestrutura
    public class Cliente
    {
        public Cliente(string cpf, string nome)
        {
            CPF = cpf;
            Nome = nome;
        }

        public string CPF { get; private set; }
        public string Nome { get; private set; }    
        


    }


    public class ServicoDeCliente
    {               
        public Boolean GravarCliente(Cliente cliente)
        {   
            return (new RepositorioCliente()).Gravar(cliente);
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


    public class Cotacao
    {
        public Cotacao(double valor,Acao acao)
        {
            Valor = valor;
        }

        public double Valor { get; private set; }
        public Acao Acao { get;  set; }

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

        
        public Cotacao RetornarCotacao(string cdAcao)
        {
            //simulando acesso ao banco
            return new Cotacao(10,this);
        }        
    }
   

    public class Operacao
    {
        //carteira deveria ter conjunto de operacoes
        public Acao Acao;
        public double vlRentabilidade;
        public Cliente Cliente;
        public int TipoOperacao;

    }

    public class DalOperacao
    {        
        public Boolean gravar(Operacao operacao)
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

                dataTable.Rows.Add(operacao.Acao.Codigo, operacao.Acao.PrAcao, operacao.Acao.Quantidade,
                operacao.Acao.CustoOperacao);

                dataSet.Tables.Add(dataTable);
            }
            else
            {
                dataSet.ReadXml("carteira.xml");
                dataTable = dataSet.Tables["carteira"];
                dataTable.Rows.Add(operacao.Acao.Codigo, operacao.Acao.PrAcao, operacao.Acao.Quantidade,
                operacao.Acao.CustoOperacao);
            }
                     
            
            dataSet.WriteXml("carteira.xml");

            return true;

        }

        public List<Operacao> RetornarOperacoes(Cliente cliente)
        {
            var operacoes = new List<Operacao>();
            DataSet dataset = new DataSet();



            dataset.ReadXml(@"C:\Users\Fabio\Dropbox\Treinamentos\ExemplosModulo2\carteira.xml");

            foreach (DataRow row in dataset.Tables[0].Rows)
            {
               operacoes.Add( new Operacao
                {
                    Acao = new Acao {Codigo = row[0].ToString(), PrAcao = Convert.ToDouble(row[1]), Quantidade = Convert.ToInt16(row[2]), CustoOperacao = Convert.ToDouble(row[3])}

                });
            }
            return operacoes;
        }

    }
}
