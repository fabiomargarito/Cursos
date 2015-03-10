using MBCorpHealthTest.Dominio.Entidades;
using MBCorpHealthTest.Dominio.EventosDeDominio;

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

            EventosDoDominio.Disparar(new AgendamentoCriado(agendamento));

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