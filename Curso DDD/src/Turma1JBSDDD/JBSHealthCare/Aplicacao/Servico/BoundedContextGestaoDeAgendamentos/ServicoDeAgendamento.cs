using JBSHealthCare.Dominio.Entidade;
using JBSHealthCare.Dominio.Entidade.BoundedContextGestaoDeAgendamentos;
using JBSHealthCare.Dominio.EventoDominio;
using JBSHealthCare.Dominio.EventoDominio.BoundedContextGestaoDeAgendamentos;
using JBSHealthCare.Dominio.Fabrica;
using JBSHealthCare.Dominio.Fabrica.BoundedContextGestaoDeAgendamentos;
using JBSHealthCare.Dominio.Interface.Repositorio;
using JBSHealthCare.Dominio.Interface.Repositorio.BoundedContextGestaoDeAgendamentos;
using JBSHealthCare.View.ViewModels;
using JBSHealthCare.View.ViewModels.BoundedContextGestaoDeAgendamentos;

namespace JBSHealthCare.Aplicacao.Servico.BoundedContextGestaoDeAgendamentos
{
    public class ServicoDeAgendamento
    {
        private readonly IAgendamentos _agendamentos;

        public ServicoDeAgendamento(IAgendamentos agendamentos)
        {
            _agendamentos = agendamentos;
        }

        public bool CriarAgendamento(AgendamentoViewModel agendamentoViewModel)
        {            
            FabricaDeAgendamento fabricaDeAgendamento = new FabricaDeAgendamento();
            Agendamento agendamento =  fabricaDeAgendamento.InformarCID(agendamentoViewModel.numeroCID)
                .InformarMedico(agendamentoViewModel.crm)
                .InformarPaciente(agendamentoViewModel.cpf)
                .Criar();

            _agendamentos.Gravar(agendamento);

            EventosDoDominio.Disparar(new AgendamentoCriado(agendamentoViewModel));

            return true;
        }
    }
}