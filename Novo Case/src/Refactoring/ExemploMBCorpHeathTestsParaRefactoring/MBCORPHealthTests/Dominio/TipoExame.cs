using System;
using System.Collections.Generic;

namespace MBCORPHealthTests
{
    public class TipoExame
    {
        public TipoExame(string nomeExame)
        {
            if (string.IsNullOrEmpty(NomeExame)) throw new Exception("NomeExame inválido");
           
            NomeExame = nomeExame;
        }

        public string NomeExame { get; private set; }
        public IEnumerable<DateTime> AgendaDisponibilidade { get; private set; }

        public void GerarAgendaDeDisponibilidade()
        {
            //Aqui teríamos alguma regra para gerar a agenda

            var agenda = new List<DateTime>();
            agenda.Add(DateTime.Now);

            //fim algoritmo gerador de agenda

            AgendaDisponibilidade = agenda;
        }
    }
}