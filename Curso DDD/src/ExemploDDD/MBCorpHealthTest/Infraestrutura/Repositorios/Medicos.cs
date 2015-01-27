using System.Security.Cryptography.X509Certificates;
using MBCorpHealthTest.Dominio.Contratos;
using MBCorpHealthTest.Dominio.Entidades;
using NHibernate;
using NHibernate.Engine;

namespace MBCorpHealthTest.Infraestrutura.Repositorios
{

    public   class MedicosFake : IMedicos
    {
        public virtual  Medico PesquisarMedicoPorCRMEEstado(string crm, string estado)
        {
            return new Medico(crm, "fabio", estado);
        }
    }



    public   class Medicos : IMedicos
    {
        protected readonly ISession _session;

        public   Medicos(ISession session)
        {
            _session = session;
        }

        public virtual  Medico PesquisarMedicoPorCRMEEstado(string crm, string estado)
        {
            
                return
                    _session.QueryOver<Medico>().Where(campo=>campo.CRM==crm).And(campo=>campo.Estado==estado)
                        .SingleOrDefault();
            
        }
    }
}