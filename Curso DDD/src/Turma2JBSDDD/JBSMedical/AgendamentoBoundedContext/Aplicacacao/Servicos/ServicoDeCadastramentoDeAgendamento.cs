using JBSMedical.AgendamentoBoundedContext.Aplicacacao.Contratos;
using JBSMedical.AgendamentoBoundedContext.Dominio.Entidades;
using JBSMedical.CadastrosBoundedContext.Infraestrutura.Contratos;
using JBSMedical.CadastrosBoundedContext.Infraestrutura.Repositorios;

namespace JBSMedical.AgendamentoBoundedContext.Aplicacacao.Servicos
{
    public class ServicoDeCadastramentoDeAgendamento : IServicoDeCadastramentoDeAgendamento
    {
        private readonly ISessionORM _sessionOrm;

        public ServicoDeCadastramentoDeAgendamento(ISessionORM sessionOrm)
        {
            _sessionOrm = sessionOrm;
        }

        public bool Cadastrar(Agendamento agendamento)
        {
            ((SessionORMNHibernate)_sessionOrm).Sessao.Save(agendamento);
            return true;
        }
    }
}