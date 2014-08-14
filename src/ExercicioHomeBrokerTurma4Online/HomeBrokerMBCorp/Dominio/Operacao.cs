namespace HomeBrokerMBCorp.Dominio
{
    public class Operacao
    {
        public Acao Acao { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public Usuario Usuario { get; set; }
        public Corretora Corretora { get; set; }
    }
}