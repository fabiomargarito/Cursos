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

            if (string.IsNullOrEmpty(paciente.CPF))
                throw new ArgumentNullException("Paciente inválido");

            if (string.IsNullOrEmpty(medicoSolicitante.CRM))
                throw new ArgumentException("Médico Inválido");

            Paciente = paciente;
            MedicoSolicitante = medicoSolicitante;
        }

        public void AdicionarExame(Exame exame)
        {
            if (Exames == null)
                Exames = new HashSet<Exame>();

            if (String.IsNullOrEmpty(exame.TipoExame.NomeExame))
                throw new ArgumentException("Exame Inválido");

            if (Paciente.PlanoDeSaude.VerificarCobertura(exame) == true)
                exame.InformarValorDoExame(0);
            
            Exames.Add(exame);
        }

        public Credencial GerarCredencialInicial(Pessoa pessoa)
        {
            var credencial = new Credencial(string.Format("{0}{1}", pessoa.Nome.Split(' ')[0], pessoa.CPF),pessoa.CPF);            
            return credencial;
        }

        public Endereco ConsultarEnderecoNosCorreios(string cep, TipoServicoDeConsulta tipoServicoDeConsulta)
        {
           if (tipoServicoDeConsulta == TipoServicoDeConsulta.ServicoCorporativo)
            //consultaria serviço web dos correios
            return new Endereco("rua 1","casa 1" ,"vila madalena","São Paulo","SP","02234143");
           else
           {
               if(tipoServicoDeConsulta==TipoServicoDeConsulta.ServicoCorporativo)
                   //consultaria serviço corporativo da empresa
                   return new Endereco("rua 1", "casa 1", "vila madalena", "São Paulo", "SP", "02234143");
           }
            return null;
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