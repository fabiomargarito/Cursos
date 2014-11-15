namespace MBCorpHealth.Dominio.Contratos
{
    public abstract class ServicoDePagamento
    {
        public bool ClienteVIP { get; set; }

        public abstract bool  RealizarPagamento(Cartao cartao, double valor);
        
    }
}
