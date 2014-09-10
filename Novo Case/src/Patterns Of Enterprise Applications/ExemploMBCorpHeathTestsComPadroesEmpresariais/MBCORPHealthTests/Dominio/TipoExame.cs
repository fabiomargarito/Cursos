using System;
using System.Collections.Generic;

namespace MBCORPHealthTests
{
    public class TipoExame
    {
        public  TipoExame(string nomeExame)
        {
            if (string.IsNullOrEmpty(NomeExame)) throw new Exception("NomeExame inválido");
           
            NomeExame = nomeExame;
        }

        public TipoExame()
        {
        }

        public virtual string NomeExame { get; protected set; }
        public virtual IEnumerable<DateTime> AgendaDisponibilidade { get; protected set; }

        public virtual void GerarAgendaDeDisponibilidade()
        {
            //Aqui teríamos alguma regra para gerar a agenda

            var agenda = new List<DateTime>();
            agenda.Add(DateTime.Now);

            //fim algoritmo gerador de agenda

            AgendaDisponibilidade = agenda;
        }
    }
}