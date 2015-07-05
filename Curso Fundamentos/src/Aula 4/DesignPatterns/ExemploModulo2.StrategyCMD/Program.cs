using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy;

namespace ExemploModulo2.StrategyCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculoIcm calculoIcm = (new FabricaIcms()).Criar(Estado.SP);
            Console.WriteLine(string.Format("Valor do icms {0}",calculoIcm.CalcularImposto(100)));
            Console.ReadLine();
        }
    }
}
