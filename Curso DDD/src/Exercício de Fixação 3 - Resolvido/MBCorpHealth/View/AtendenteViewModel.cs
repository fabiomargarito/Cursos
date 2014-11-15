namespace TestesUnitarios
{
    public class AtendenteViewModel
    {
        public int NumeroMatricula;
        public string Nome;
        public string Cpf;

        public AtendenteViewModel(string nome, string cpf, int matricula)
        {
            NumeroMatricula = matricula;
            Nome = nome;
            Cpf = cpf;
        }
    }
}