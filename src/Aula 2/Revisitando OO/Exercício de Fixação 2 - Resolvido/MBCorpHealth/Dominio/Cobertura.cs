using System;

namespace MBCorpHealth.Dominio
{
    public class Cobertura
    {
        public string Nome { get; private set; }

        public Cobertura(string nome)
        {
            ValidarDadosDaCobertura(nome);
            Nome = nome;
        }

        private void ValidarDadosDaCobertura(string nome)
        {
            if (string.IsNullOrEmpty(nome) ) throw new ArgumentException("É necessário informar o nome da cobertura!");
        }

    }
}