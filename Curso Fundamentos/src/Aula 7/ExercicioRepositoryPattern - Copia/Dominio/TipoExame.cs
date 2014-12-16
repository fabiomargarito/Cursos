using System;

namespace MBCorpHealth.Dominio
{
    public class TipoExame
    {
        public string NomeExame { get; private set; }

        public TipoExame(string nomeExame)
        {
            ValidarDadosDoTipoDeExame(nomeExame);
            NomeExame = nomeExame;
        }

        private void ValidarDadosDoTipoDeExame(string nomeExame)
        {
            if (string.IsNullOrEmpty(nomeExame)) throw new ArgumentNullException("É necessário informar o nome do exame!");
        }
    }
}