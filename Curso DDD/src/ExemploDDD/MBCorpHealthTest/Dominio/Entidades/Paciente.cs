namespace MBCorpHealthTest.Dominio.Entidades
{
    public   class Paciente
    {
        public   Paciente(string cpf, string nome, string email)
        {
            CPF = cpf;
            Nome = nome;
            Email = email;
        }

        public Paciente()
        {
        }

        public virtual  string CPF { get; protected set; }
        public virtual  string Nome { get; protected set; }
        public virtual  PlanoDeSaude PlanoDeSaude { get; protected set; }
        public virtual  string Email { get; protected set; }

        //TODO: Criar método de validação
    }
}