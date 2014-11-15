namespace MBCorpHealth.Dominio
{
    public class MedicoFabrica
    {
        public static Medico Criar(string crm, string nome)
        {
            return new Medico(nome, "", crm);
        }
    }
}