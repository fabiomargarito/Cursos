namespace MBCorpHealthTest.Dominio.ContextoCadastrosCorporativos.Entidades
{
    public class Atendente
    {
        public Atendente(string cpf, string nome)
        {
            CPF = cpf;
            Nome = nome;
        }

        protected Atendente()
        {
        }

        public string CPF { get; protected set; }
        public string Nome { get; protected set; }

        //todo Criar validação
    }
}