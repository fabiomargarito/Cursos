namespace HomeBrokerMBCorp.Dominio
{
    public class Acao
    {
        public string Codigo { get; private set; }
        public Empresa Empresa { get; private set; }
        public Tipo Tipo { get; private set; }

    }

    public enum Tipo
    {
        PR,
        ON
    }
}