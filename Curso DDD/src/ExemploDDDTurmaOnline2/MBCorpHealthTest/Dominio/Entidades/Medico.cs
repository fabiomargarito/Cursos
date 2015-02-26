namespace MBCorpHealthTest.Dominio.Entidades
{
    public class Medico
    {
        public Medico(string crm, string nome)
        {
            CRM = crm;
        }

        public Medico()
        {
        }

        public string CRM { get; set; }
        public string Nome { get; set; }
    }
}