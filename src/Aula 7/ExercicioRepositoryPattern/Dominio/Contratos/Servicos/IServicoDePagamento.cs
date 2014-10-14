namespace MBCorpHealth.Dominio.Contratos.Servicos
{
    public interface IServicoDePagamento
    {
        bool RealizarPagamento(Cartao cartao, double valor);        
    }
}
