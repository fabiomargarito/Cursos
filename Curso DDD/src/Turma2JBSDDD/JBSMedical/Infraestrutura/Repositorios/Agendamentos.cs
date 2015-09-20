using JBSMedical.Dominio.Contratos.Repositorios;
using JBSMedical.Dominio.Entidades;
using NHibernate;

namespace JBSMedical.Infraestrutura.Repositorios
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