using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBCorpHealth.Dominio
{
    public class Agendamento
    {

        public int Identificador { get; private set; }
        public Paciente Paciente { get; private set; }
        public Medico MedicoSolicitante { get; private set; }
        public ISet<Exame> Exames { get; private set; }             

        public void CriarAgendamento(Paciente paciente, Medico medicoSolicitante)
        {
            
          
            ValidarDadosDoAgendamento(paciente,medicoSolicitante);

            Paciente = paciente;
            MedicoSolicitante = medicoSolicitante;

        }

        private void ValidarDadosDoAgendamento(Paciente paciente, Medico medicoSolicitante)
        {

            if (string.IsNullOrEmpty(paciente.CPF))
                throw new ArgumentNullException("Paciente inválido");

            if (string.IsNullOrEmpty(medicoSolicitante.CRM))
                throw new ArgumentException("Médico Inválido");
        }
        
        public void AdicionarExame(Exame exame)
        {
            ValidarDadosDoExame(exame);
            Exames.Add(exame);
        }

        private void ValidarDadosDoExame(Exame exame)
        {
            if (Exames == null)
                Exames = new HashSet<Exame>();

            if (String.IsNullOrEmpty(exame.TipoExame.NomeExame))
                throw new ArgumentException("Exame Inválido");

        }
    }
}