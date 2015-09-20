namespace JBSMedical.Dominio.Entidades
{
    public class TipoExame
    {
        public TipoExame()
        {
        }

        public string Codigo { get; protected set; }
        public string Descricao { get; protected set; }

        public TipoExame(string Codigo, string descricao)
        {
            this.Codigo = Codigo;
            Descricao = descricao;
        }
    }
}