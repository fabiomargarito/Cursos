using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Contratos;
using MBCorpHealthTest.Dominio.ContextoCadastrosCorporativos.Entidades;
using NHibernate;

namespace MBCorpHealthTest.Infraestrutura.ContextoCadastrosCorporativos
{
    public class MedicosFake : IMedicos
    {
        public Medico PesquisarMedicoPorCRMEEstado(string crm, string estado)
        {
            return new Medico(crm, "fabio", estado);
        }
    }

    public class Medicos : IMedicos
    {
        private readonly ISession _session;

        public Medicos(ISession session)
        {
            _session = session;
        }

        public Medico PesquisarMedicoPorCRMEEstado(string crm, string estado)
        {
                return
                    _session.QueryOver<Medico>().Where(campo=>campo.CRM==crm).And(campo=>campo.Estado==estado)
                        .SingleOrDefault();
        }
    }
}