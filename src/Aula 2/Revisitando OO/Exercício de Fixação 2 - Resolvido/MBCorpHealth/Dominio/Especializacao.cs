using System;

namespace MBCorpHealth.Dominio
{
    public class EspecializacaoMedica
    {
        public string Nome { get; private set; }

        public EspecializacaoMedica(string nome)
        {
            ValidarDadosDaEspecializacaoMedica(nome);
            Nome = nome;
        }

        private void ValidarDadosDaEspecializacaoMedica(string nome)
        {
            if (string.IsNullOrEmpty(nome)) throw new ArgumentNullException("É necessário informar o nome da especialização médica!");
        }        
    }
}