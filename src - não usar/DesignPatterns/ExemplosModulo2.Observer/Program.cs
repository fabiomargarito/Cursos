using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Observer;
namespace ExemplosModulo2.Observer
{
    class Program
    {
        static void Main(string[] args)
        {

            //subject
            Acao vale = new VALE("VALE3", 100);


            vale.Cadastrar(new InvestidorPessoaFisica("Fabio Margarito"));
            vale.Cadastrar(new InvestidorPessoaFisica("Marlene Margarito"));
            vale.Cadastrar(new InvestidorPessoaFisica("Marcos"));
            vale.Cadastrar(new InvestidorPessoaFisica("Leandro"));
            vale.Cadastrar(new InvestidorPessoaFisica("Marcio"));
            vale.Cadastrar(new InvestidorPessoaJuridica("Silvio","000.112.345/0001-30", new ServicoCompraAcaoItauTrade()));

            vale.Preco = 120;
            vale.Preco = 170;
            vale.Preco = 220;
            vale.Preco = 123;

            Console.ReadKey(); 

        }
    }
}
