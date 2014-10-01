namespace MBCorpHealth.Dominio.Contratos
{
    interface IServicoDePagamento
    {
        bool RealizarPagamento(Cartao cartao, double valor);
        
    }
}
