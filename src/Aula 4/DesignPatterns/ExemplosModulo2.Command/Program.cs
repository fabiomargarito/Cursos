using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Command;

namespace ExemplosModulo2.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Corretora corretora = new Corretora();

            OrdemDeCompra ordemDeCompra1 = new OrdemDeCompra(corretora);
            OrdemDeCompra ordemDeCompra2 = new OrdemDeCompra(corretora);
            OrdemDeVenda  ordemDeVenda = new OrdemDeVenda(corretora);

            Corretor corretor = new Corretor();
            corretor.EnviarOrdem(ordemDeCompra1);
            corretor.EnviarOrdem(ordemDeCompra2);
            corretor.EnviarOrdem(ordemDeVenda);
            

            Console.ReadKey();

        }
    }
}
