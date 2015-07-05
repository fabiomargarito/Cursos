using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface ICalculoIcm
    {
        double CalcularImposto(double valor);
    }

    public class CalculoICMSEspiritoSanto : ICalculoIcm
    {
        public double CalcularImposto(double valor)
        {
            return valor * 0.13;
        }
    }

    public class CalculoICMSSaoPaulo : ICalculoIcm
    {
        public double CalcularImposto(double valor)
        {
            return valor * 0.15;
        }
    }

    public class CalculoICMSRioDeJaneiro : ICalculoIcm
    {
        public double CalcularImposto(double valor)
        {
            return valor * 0.2;
        }
    }

    public class CalculoICMSPernanbuco : ICalculoIcm
    {
        public double CalcularImposto(double valor)
        {
            return valor * 0.3;
        }
    }

    public class CalculoICMSParaiba : ICalculoIcm
    {
        public double CalcularImposto(double valor)
        {
            return valor * 0.6;
        }
    }

    public class CalculoICMSMatoGrosso : ICalculoIcm
    {
        public double CalcularImposto(double valor)
        {
            return valor * 0.4;
        }
    }

    /// <summary>
    /// Esta classe possui algumas dicas para documentação XML.
    /// </summary>
    public class FabricaIcms
    {
        public ICalculoIcm Criar(Estado estado)
        {
            switch (estado)
            {
                case Estado.SP: return new CalculoICMSSaoPaulo();
                case Estado.RJ: return new CalculoICMSRioDeJaneiro();
                case Estado.ES: return new CalculoICMSEspiritoSanto();
                case Estado.PE: return new CalculoICMSPernanbuco();
                case Estado.PB: return new CalculoICMSParaiba();
                default: throw new Exception("Nehum estado selecionado");
            }
        }
    }

    public enum Estado
    {
        SP,
        RJ,
        ES,
        PE,
        PB
    }


}
