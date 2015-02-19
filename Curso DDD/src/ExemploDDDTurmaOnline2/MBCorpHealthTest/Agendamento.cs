using System;
using System.Collections.Generic;
using System.Linq;

namespace MBCorpHealthTestTests
{
    public class Agendamento
    {
        //Identificador da Entidade
        public string Numero { get; private set; }

        public Agendamento(Atendente atendente, Medico medico)
        {
            Atendente = atendente;            
            Medico = medico;

            Exames = new List<Exame>();
        }

        public Medico Medico { get; private set; }
        public Paciente Paciente { get; private set; }
        public Atendente Atendente { get; private set; }
        public CID CID { get; set; }
        public IEnumerable<Exame> Exames
        { get; set; }

        public void InformarPaciente(Paciente paciente)
        {
            Paciente = paciente;
        }

        public void InformarCID(CID cid)
        {
            CID = cid;
        }

        public void AdicionarExame(Exame exame)
        {
            if(exame ==null)
                throw new Exception("É necessário informar um exame válido");

            (Exames as IList<Exame>).Add(exame);
        }

        public double CalcularValorTotal()
        {
            return Exames.Sum(exame => exame.TipoExame.Preco);
        }
    }
}