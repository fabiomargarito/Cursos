public class Atendente
{
    public Atendente(string cpf, string nome)
    {
        CPF = cpf;
        Nome = nome;
    }

    public string CPF { get; private set; }
    public string Nome { get; private set; }

    //todo Criar validação
}