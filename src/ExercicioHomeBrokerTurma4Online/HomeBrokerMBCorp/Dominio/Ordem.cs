namespace HomeBrokerMBCorp.Dominio
{
    public class Ordem
    {
        public Acao Acao { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public Usuario Usuario { get; set; }
        public TipoOperacao TipoOperacao {get; set; }
    }
}