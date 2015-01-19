public class PlanoDeSaude
{
    public PlanoDeSaude(string cnpj, string nome, string tipoDoPlano)
    {
        CNPJ = cnpj;
        Nome = nome;
        TipoDoPlano = tipoDoPlano;
    }

    public string CNPJ { get; private set; }
    public string Nome { get; private set; }
    public string TipoDoPlano { get; private set; }

    //todo incluir validação
}