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
            ICalculoIcm calculoIcm = (new FabricaICMS()).Criar(Estado.PB;
            Console.WriteLine(calculoIcm.CalcularImposto(100));
            Console.ReadKey();
        }
    }
}
