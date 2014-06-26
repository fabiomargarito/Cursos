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
            VALE vale = new VALE("VALE3", 100);


            vale.Cadastrar(new Investidor("Fabio Margarito"));
            vale.Cadastrar(new Investidor("Marlene Margarito"));



            vale.Preco = 120;
            vale.Preco = 170;
            vale.Preco = 220;
            vale.Preco = 123;

            Console.ReadKey(); 

        }
    }
}
