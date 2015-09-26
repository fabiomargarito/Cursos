using JBSMedical.AgendamentoBoundedContext.Dominio.Contratos.Repositorios;
using JBSMedical.AgendamentoBoundedContext.Dominio.Entidades;
using NHibernate;

namespace JBSMedical.AgendamentoBoundedContext.Infraestrutura.Repositorios
{
    public class Agendamentos : IAgendamentos
    {
        private readonly ISession _session;

        public Agendamentos(ISession session)
        {
            _session = session;
        }

        public bool Cadastrar(Agendamento agendamento)
        {

            _session.Save(agendamento);
            _session.Flush();
            

            return true;
        }
    }
}