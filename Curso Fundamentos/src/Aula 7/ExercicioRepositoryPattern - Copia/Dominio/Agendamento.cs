using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using MBCorpHealth.Dominio.Contratos;
using MBCorpHealth.Infraestrutura.Servico;

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
            if (paciente ==null)
                throw new ArgumentNullException("Paciente inválido");

            if (medicoSolicitante == null)
                throw new ArgumentException("Médico Inválido");
        }

        public void AdicionarExame(Exame exame)
        {
            
            ValidarDadosParaAgendamento(exame);

            if (Paciente.PlDeSaude.VerificarCobertura(exame) == true)
                exame.InformarValorDoExame(0);
            
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
        
    }
}