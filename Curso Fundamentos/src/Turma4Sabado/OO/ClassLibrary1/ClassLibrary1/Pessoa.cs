using System;

namespace CadastroBasico
{
    class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public int CalcularIdade()
        {
            return DateTime.Now.Year - DataNascimento.Year;
        }

    }
}
