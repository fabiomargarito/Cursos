using JBSMedical.Aplicacacao.Contratos;
using JBSMedical.Dominio.Entidades;
using JBSMedical.Infraestrutura.Contratos;
using JBSMedical.Infraestrutura.Repositorios;

namespace JBSMedical.Aplicacacao.Servicos
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