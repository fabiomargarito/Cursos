namespace MBCORPHealthTests
{
    public class Medico
    {
        public Medico(string crm, string nome)
        {
            CRM = crm;
            Nome = nome;
        }

        public string CRM { get; private set; }
        public string Nome { get; private set; }
    }
}
