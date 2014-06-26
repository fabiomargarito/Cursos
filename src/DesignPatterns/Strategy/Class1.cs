using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface ICalculoIcm
    {
        double CalcularImposto(double valor);
    }


    public class CalculoICMSSaoPaulo:ICalculoIcm
    {
        public double CalcularImposto(double valor)
        {
            return valor*0.15;
        }
    }

    public class CalculoICMSRioDeJaneiro : ICalculoIcm
    {
        public double CalcularImposto(double valor)
        {
            return valor * 0.2;
        }
    }
}
