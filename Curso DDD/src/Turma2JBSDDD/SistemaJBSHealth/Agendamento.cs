using System;
using System.Collections;
using System.Collections.Generic;
using JBSMedical;

namespace SistemaJBSHealth
{
    public class Agendamento
    {
        public Agendamento()
        {
            if (Exames == null)
                Exames = new List<Exame>();
            ID = Guid.NewGuid();
        }


        public Guid ID { get; protected set; }
        public Medico Medico { get; protected set; }
        public Paciente Paciente { get; protected set; }
        public IEnumerable Exames { get; protected set; }

        public void InformarMedico(Medico medico)
        {
            Medico = medico;
        }

        public void InformarPaciente(Paciente paciente)
        {
            Paciente = paciente;
        }

        public void AdicionarExame(Exame exame)
        {
            ((IList<Exame>) Exames).Add(exame);
        }
    }
}