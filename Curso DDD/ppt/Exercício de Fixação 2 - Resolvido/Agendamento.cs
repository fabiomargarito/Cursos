using System;
using System.Collections.Generic;
using System.Linq;

namespace MBCorpHealth.Dominio
{
    public class Agendamento
    {

        public int Identificador { get; private set; }
        public Paciente Paciente { get; private set; }
        public Medico MedicoSolicitante { get; private set; }
        public ISet<Exame> Exames { get; private set; }             

  

        private void ValidarDadosDoAgendamento(Paciente paciente, Medico medicoSolicitante)
        {
            if (paciente ==null)
                throw new ArgumentNullException("Paciente inválido");

            if (medicoSolicitante == null)
                throw new ArgumentException("Médico Inválido");
        }

        public void AdicionarExame(Exame exame)
        {
            
            ValidarDadosParaAgendamento(exame);           
            
            Exames.Add(exame);
        }

        public void ValidarDadosParaAgendamento(Exame exame)
        {
            if (Exames == null)
                Exames = new HashSet<Exame>();

            if (String.IsNullOrEmpty(exame.TipoExame.NomeExame))
                throw new ArgumentException("Exame Inválido");

        }

        public double RetornarValorTotalDoAgendamento()
        {
            return double.MinValue + Exames.Sum(exame => exame.ValorDoExame);
        }

        public void InformarPaciente(Paciente paciente)
        {
            this.Paciente = paciente;
        }

        public void InformarMedicoSolicitante(Medico medicoSolicitante)
        {
            MedicoSolicitante = medicoSolicitante;
        }
    }
}