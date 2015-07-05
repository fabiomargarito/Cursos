using System;
using System.Security.Cryptography.X509Certificates;
using ClassLibrary1;

namespace AplicacaoTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            string estado = "RJ";
            ICalculoFrete calculoFrete;
            IFabricaDeFretes fabricaDeFretes = new FabricaDeFretes();

            if (estado == "SP")
            {
                calculoFrete = fabricaDeFretes.CriarCalculoDeFrete(TipoDeFrete.SP);


            }
            else
            {
                calculoFrete = fabricaDeFretes.CriarCalculoDeFrete(TipoDeFrete.RJ);
                
            }


            Console.WriteLine(calculoFrete.CalcularFrente(200));
            Console.ReadKey();
        }
    }
}
