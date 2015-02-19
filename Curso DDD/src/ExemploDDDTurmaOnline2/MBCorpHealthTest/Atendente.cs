namespace MBCorpHealthTestTests
{
    public class Atendente
    {
        public Atendente(string cpf, string nome)
        {
            CPF = cpf;
        }

        public string CPF { get; private set; }
    }
}