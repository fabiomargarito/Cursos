namespace MBCorpHealthTest.Dominio.Entidades
{
    public class Paciente
    {
        public Paciente(string cpf, string nome)
        {
            CPF = cpf;
        }

        public Paciente()
        {
        }

        public string CPF { get; set; }
        public string Nome { get; set; }
    }
}