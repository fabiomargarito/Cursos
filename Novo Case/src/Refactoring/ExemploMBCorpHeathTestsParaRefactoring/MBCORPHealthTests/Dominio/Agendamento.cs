using System;
using System.Collections.Generic;

namespace MBCORPHealthTests
{
    public class Agendamento
    {
        public Agendamento(Medico medicoSolicitante, Paciente paciente, Atendente atendente)
        {
            MedicoSolicitante = medicoSolicitante;
            Paciente = paciente;
            Atendente = atendente;
        }

        public int Codigo { get; private set; }
        public Atendente Atendente { get; private set; }
        public Paciente Paciente { get; private set; }
        public IList<Exame> Exames { get; private set; }
        public Medico MedicoSolicitante { get; private set; }
        


        public void AdicionarExame(Exame exame)
        {            

            if (Exames == null)
                Exames= new List<Exame>();

            if((Paciente.PlanoSaude.ConsultarCobertura(exame.TipoExame)==false))
                throw new Exception("Plano não cobre este este exame!!!!");

            Exames.Add(exame);
        }
    }
}