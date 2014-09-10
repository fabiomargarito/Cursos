using System;

namespace MBCORPHealthTests
{
    public class Atendente
    {
        public Atendente(string nome, string cpf)
        {
            if (string.IsNullOrEmpty(nome)) throw new Exception("nome inválido");
            if (string.IsNullOrEmpty(cpf)) throw new Exception("cpf inválido");

            Nome = nome;
            CPF = cpf;
        }

        public string Nome { get; private set; }
        public string CPF { get; private set; }
    }
}