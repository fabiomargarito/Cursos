namespace MBCorpHealthTest.Dominio.Entidades
{
    public class Atendente
    {
        public Atendente(string cpf, string nome)
        {
            CPF = cpf;
        }

        public Atendente()
        {
        }

        public string CPF { get; private set; }
        public string Nome { get; set; }
    }
}