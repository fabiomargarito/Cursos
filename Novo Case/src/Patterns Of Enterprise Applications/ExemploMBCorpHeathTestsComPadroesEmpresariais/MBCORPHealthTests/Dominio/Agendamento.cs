using System;
using System.Collections.Generic;

namespace MBCORPHealthTests
{
    public class Agendamento
    {
        public  Agendamento(Medico medicoSolicitante, Paciente paciente, Atendente atendente)
        {
            MedicoSolicitante = medicoSolicitante;
            Paciente = paciente;
            Atendente = atendente;
        }

        public Agendamento()
        {
        }

        public virtual int Codigo { get; protected set; }
        public virtual Atendente Atendente { get; protected set; }
        public virtual Paciente Paciente { get; protected set; }
        public virtual IList<Exame> Exames { get; protected set; }
        public virtual Medico MedicoSolicitante { get; protected set; }
        


        public virtual void AdicionarExame(Exame exame)
        {            

            if (Exames == null)
                Exames= new List<Exame>();

            if((Paciente.PlanoSaude.ConsultarCobertura(exame.TipoExame)==false))
                throw new Exception("Plano não cobre este este exame!!!!");

            Exames.Add(exame);
        }
    }
}