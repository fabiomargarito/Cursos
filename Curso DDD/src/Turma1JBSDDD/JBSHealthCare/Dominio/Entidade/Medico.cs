namespace JBSHealthCare.Dominio.Entidade
{
    public class Medico
    {
        public string Crm { get; }
        public string Nome { get; set; }

        public Medico(string crm, string nome)
        {
            this.Crm = crm;
            Nome = nome;
        }
    }
}