using MBCorpHealthTest.Aplicacao.Servicos;
using MBCorpHealthTest.Dominio.Entidades;
using NHibernate;

namespace MBCorpHealthTestTests
{
    public class Agendamentos : IAgendamentos
    {
        private readonly ISession _session;

        public Agendamentos(ISession session)
        {
            _session = session;
        }

        public bool Gravar(Agendamento agendamento)
        {
            _session.SaveOrUpdate(agendamento);
            _session.Flush();
            return true;
        }
    }
}