using System.Collections.Generic;
using System.Xml.Serialization;
using HomeBrokerMBCorp.Dominio;

namespace TesteDeDominio
{
    class Program
    {
        static void Main(string[] args)
        {            
            Imposto imposto = new CustoIR();
            imposto.CalcularImposto(100);


            IEstrategiaCorretagem estrategiaCorretagem =
                (new EstrategiaCorretagemFactory()).CriarEstrategiaCorretagem(TipoCorretora.ITAU);
            var valorCorretagem = estrategiaCorretagem.CalcularCorretagem(1000);
        }    
    }  
}
