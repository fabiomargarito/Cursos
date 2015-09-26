namespace JBSMedical.CadastrosBoundedContext.Dominio.Entidades
{
    public class Medico
    {
        public Medico()
        {
        }

        public Medico(string crm, string nome)
        {
            CRM = crm;
            Nome = nome;
        }

        public string CRM { get; protected set; }
        public string Nome { get; protected set; }
    }
}