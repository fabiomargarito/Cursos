using System;

namespace MBCorpHealthTest.Dominio.Entidades
{
    public   class TipoExame
    {
        //Classificação Brasileira Hierarquizada de Procedimentos Médicos
        public   TipoExame(string cbhpm, string descricao, Double valor)
        {
            CBHPM = cbhpm;
            Descricao = descricao;
            Valor = valor;
        }

        public TipoExame()
        {
        }

        public virtual  string CBHPM { get; protected set; }
        public virtual  string Descricao { get; protected set; }
        public virtual  double Valor { get; set; }

        //Todo Criar método de validação
    }
}