using JBSMedical.Infraestrutura.Contratos;
using NHibernate;

namespace JBSMedical.Infraestrutura.Repositorios
{
    public class SessionORMNHibernate : ISessionORM
    {
        public ISession Sessao { get; set; }
    }
}