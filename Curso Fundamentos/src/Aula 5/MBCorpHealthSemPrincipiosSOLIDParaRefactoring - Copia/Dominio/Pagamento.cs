using MBCorpHealth.Infraestrutura.Servico;

namespace MBCorpHealth.Dominio
{
    public class ServicoDePagamento
    {
        public bool RealizarPagamesnto(Cartao cartao, double valor)
        {
            ServicoDePagamentoMaster servicoDePagamento = new ServicoDePagamentoMaster();
            return servicoDePagamento.RealizarPagamento(cartao, valor);
        }
    }
}
