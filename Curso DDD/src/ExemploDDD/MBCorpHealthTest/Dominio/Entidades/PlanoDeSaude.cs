namespace MBCorpHealthTest.Dominio.Entidades
{
    public   class PlanoDeSaude
    {
        public   PlanoDeSaude(string cnpj, string nome, string tipoDoPlano)
        {
            CNPJ = cnpj;
            Nome = nome;
            TipoDoPlano = tipoDoPlano;
        }

        public PlanoDeSaude()
        {
        }

        public virtual  string CNPJ { get; protected set; }
        public virtual  string Nome { get; protected set; }
        public virtual  string TipoDoPlano { get; protected set; }

        //todo incluir validação
    }
}