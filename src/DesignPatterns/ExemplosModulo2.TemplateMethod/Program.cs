 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 using TemplateMethod;

namespace ExemplosModulo2.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = new DALCliente();            
            var retorno = teste.Executar();

            Console.ReadKey();

        }
    }
}
