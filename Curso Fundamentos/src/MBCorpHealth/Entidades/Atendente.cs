using System;

namespace ExemploDeCriacaoDeUmRepositorioTurma4
{
    public class Atendente
    {
        public Atendente() {
        }

        public Atendente(string cpf,string nome,DateTime dataNascimento) {
            CPF = cpf;
            Nome = nome;
        }
        public virtual string CPF { get; protected set; }
        public virtual string Nome { get; protected set; }
        public virtual DateTime? DataDeNascimento { get; protected set; }
    }
}