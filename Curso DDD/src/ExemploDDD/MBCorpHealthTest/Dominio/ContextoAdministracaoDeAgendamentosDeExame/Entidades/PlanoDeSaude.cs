namespace MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Entidades
{
    public class PlanoDeSaude
    {
        public PlanoDeSaude(string cnpj, string nome, string tipoDoPlano)
        {
            CNPJ = cnpj;
            Nome = nome;
            TipoDoPlano = tipoDoPlano;
        }

        protected PlanoDeSaude()
        {
        }

        public string CNPJ { get; protected set; }
        public string Nome { get; protected set; }
        public string TipoDoPlano { get; protected set; }

        //todo incluir validação
    }
}