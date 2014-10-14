using MBCorpHealth.Dominio.Contratos;
using MBCorpHealth.Infraestrutura.Servico;

namespace MBCorpHealth.Dominio
{
    class Pagamento
    {
        public bool RealizarPagamento(Cartao cartao, double valor)
        {
            IServicoDePagamento servicoDePagamento = new ServicoDePagamentoMaster();            
            return servicoDePagamento.RealizarPagamento(cartao, valor);
        }
    }
}
