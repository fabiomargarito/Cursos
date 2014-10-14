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

            ValidarDadosParaCriacaoDoExame(paciente, medicoSolicitante);
            Paciente = paciente;
            MedicoSolicitante = medicoSolicitante;
        }

        private void ValidarDadosParaCriacaoDoExame(Paciente paciente, Medico medicoSolicitante)
        {
            if (string.IsNullOrEmpty(paciente.CPF))
                throw new ArgumentNullException("Paciente inválido");

            if (string.IsNullOrEmpty(medicoSolicitante.CRM))
                throw new ArgumentException("Médico Inválido");

        }

        public void AdicionarExame(Exame exame)
        {
            
            if (Paciente.PlanoDeSaude.VerificarCobertura(exame))
                exame.InformarValorDoExame(0);
            
            ValidarDadosParaAdicaoDoExame(exame);
            Exames.Add(exame);
        }

        private void ValidarDadosParaAdicaoDoExame(Exame exame)
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
        
        

        public bool RealizarPagamento(Cartao cartao, double valor)
        {
            ServicoDePagamentoMaster servicoDePagamento = new ServicoDePagamentoMaster();
            return servicoDePagamento.RealizarPagamento(cartao, valor);
        }
    }

    public enum TipoServicoDeConsulta
    {
        ServicoCorporativo,
        ServicoCorreios
    }
}