namespace MBCorpHealthTest.Dominio.Entidades
{
    public class Paciente
    {
        public Paciente(string cpf, string nome, string email)
        {
            CPF = cpf;
            Nome = nome;
            Email = email;
        }

        protected Paciente()
        {
        }

        public string CPF { get; protected set; }
        public string Nome { get; protected set; }
        public PlanoDeSaude PlanoDeSaude { get; protected set; }
        public string Email { get; protected set; }

        //TODO: Criar método de validação
    }
}