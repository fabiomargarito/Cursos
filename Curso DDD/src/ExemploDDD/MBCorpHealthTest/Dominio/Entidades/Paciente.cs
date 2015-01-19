public class Paciente
{
    public Paciente(string cpf, string nome, string email)
    {
        CPF = cpf;
        Nome = nome;
    }

    public string CPF { get; private set; }
    public string Nome { get; private set; }
    public PlanoDeSaude PlanoDeSaude { get; private set; }
    public string Email { get; private set; }

    //TODO: Criar método de validação
}