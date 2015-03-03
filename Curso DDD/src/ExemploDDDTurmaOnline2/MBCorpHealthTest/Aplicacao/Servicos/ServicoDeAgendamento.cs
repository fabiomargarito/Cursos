using MBCorpHealthTest.Dominio.Entidades;

namespace MBCorpHealthTest.Aplicacao.Servicos
{
    public class ServicoDeAgendamento
    {
        private readonly IAgendamentos _agendamentos;

        public ServicoDeAgendamento(IAgendamentos agendamentos)
        {
            _agendamentos = agendamentos;
        }

        public bool CadastrarAgendamento(Agendamento agendamento)
        {
            //logar em arquivo o registro do agendamento

            //persistir na base o agendamento
            _agendamentos.Gravar(agendamento);

            return true;
        }
    }

    public interface IAgendamentos
    {
        bool Gravar(Agendamento agendamento);
    }
}