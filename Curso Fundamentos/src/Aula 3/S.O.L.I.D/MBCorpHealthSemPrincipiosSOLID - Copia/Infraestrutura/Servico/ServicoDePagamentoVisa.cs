using System;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos;

namespace MBCorpHealth.Infraestrutura.Servico
{
    public class ServicoDePagamentoVisa : ServicoDePagamento
    {
        public bool PontosEmDobro { get; set; }
        public override bool RealizarPagamento(Cartao cartao, double valor)
        {
            Console.WriteLine("Pagamento com Visa");
            //conecta-se como servico da Cielo e realiza o pagamento
            return true;
        }

    }

    
}
