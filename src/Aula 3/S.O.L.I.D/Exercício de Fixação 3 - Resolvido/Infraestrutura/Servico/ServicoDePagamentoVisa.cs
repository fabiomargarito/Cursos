using System;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos;

namespace MBCorpHealth.Infraestrutura.Servico
{
    class ServicoDePagamentoVisa : ServicoDePagamento
    {
        public bool PontosEmDobro { get; set; }
        public override bool RealizarPagamento(Cartao cartao, double valor)
        {
            //conecta-se como servico da Cielo e realiza o pagamento
            return true;
        }

        public bool RealizarPagamento2(Cartao cartao, double valor)
        {
            throw new NotImplementedException();
        }

        public bool RealizarPagamento3(Cartao cartao, double valor)
        {
            throw new NotImplementedException();
        }
    }
}
