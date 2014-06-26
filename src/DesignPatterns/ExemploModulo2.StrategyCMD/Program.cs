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
            string cidade = "SP";

            ICalculoIcm calculoIcm = null;

            if (cidade=="SP")
                calculoIcm = new CalculoICMSSaoPaulo();
            else 
                if(cidade=="RJ")
                    calculoIcm = new CalculoICMSRioDeJaneiro();


            Console.WriteLine(calculoIcm.CalcularImposto(100));
            Console.ReadKey();

        }
    }
}
