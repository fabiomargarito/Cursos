using System.Collections.Generic;
using JBSMedical.CadastrosBoundedContext.Dominio.Entidades;

namespace JBSMedical.AgendamentoBoundedContext.Dominio.Entidades
{
    public class Agendamento
    {
        public Agendamento()
        {
            if (Exames == null)
                Exames = new List<Exame>();            
        }


        public int ID { get; protected set; }
        public Medico Medico { get; protected set; }
        public Paciente Paciente { get; protected set; }
        public IList<Exame> Exames { get; protected set; }

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