using JBSMedical.CadastrosBoundedContext.Infraestrutura.Contratos;
using NHibernate;

namespace JBSMedical.CadastrosBoundedContext.Infraestrutura.Repositorios
{
    public class SessionORMNHibernate : ISessionORM
    {
        public ISession Sessao { get; set; }
    }
}