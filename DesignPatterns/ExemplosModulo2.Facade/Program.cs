using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facade;

namespace ExemplosModulo2.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Hipoteca hipoteca = new Hipoteca();
            var ehElegivel = hipoteca.EhElegivel((new Cliente("Fabio Margarito")), 100);
            if (ehElegivel)
                Console.WriteLine("\nO Cliente pode receber o empréstimo");
            Console.ReadKey();
        }
    }
}
