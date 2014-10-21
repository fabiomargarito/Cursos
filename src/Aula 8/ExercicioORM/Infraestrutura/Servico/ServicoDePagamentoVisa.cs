using System;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos;
using MBCorpHealth.Dominio.Contratos.Servicos;

namespace MBCorpHealth.Infraestrutura.Servico
{
    public class ServicoDePagamentoVisa : IServicoDePagamento
    {
        public bool PontosEmDobro { get; set; }
        public bool RealizarPagamento(Cartao cartao, double valor)
        {
            //conecta-se como servico da Cielo e realiza o pagamento
            return true;
        }        
    }
}
