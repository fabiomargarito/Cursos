using System;
using System.Data;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos;

namespace MBCorpHealth.Infraestrutura.Servico
{
    public class ServicoDePagamentoDinners:ServicoDePagamento
    {
    

        public override bool RealizarPagamento(Cartao cartao, double valor)
        {
            //conecta-se como servico da Cielo e realiza o pagament

            if (ClienteVIP)
            {
                Console.WriteLine("Pagamento com Dinners para cliente tem 6 vezes sem juros");
            }

            Console.WriteLine("Pagamento com Dinners");
            return true;
        }


    }
}
