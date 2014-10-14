namespace MBCorpHealth.Dominio.Contratos
{
    interface IServicoDePagamento
    {
        bool RealizarPagamento(Cartao cartao, double valor);
        bool RealizarPagamento2(Cartao cartao, double valor);
        bool RealizarPagamento3(Cartao cartao, double valor);
    }
}
