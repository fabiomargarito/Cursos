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
            var dalCliente = new DALCliente();            
            var retorno = dalCliente.Executar();

            var dalAcao = new DALACAO();
            var retornoAcao = dalAcao.Executar();

            Console.ReadKey();

        }
    }
}
