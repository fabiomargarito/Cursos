using System.Collections.Generic;
using System.Linq;
using MBCorpHealthTest.Dominio.Entidades;
using NHibernate;
using NHibernate.Linq;

namespace MBCorpHealthTestTests
{
    public class Medicos : IMedicos
    {
        private readonly ISession _session;

        public Medicos(ISession session)
        {
            _session = session;
        }

        public Medico ConsultarPorCRM(string CRM)
        {
            return _session.Query<Medico>().SingleOrDefault(campo => campo.CRM == CRM);

        }

        public IList<Medico> ConsultarPorTrechoDoNome(string Nome)
        {

            return _session.Query<Medico>().Where(campo => campo.Nome.Contains(Nome)).ToList();
        }
    }
}