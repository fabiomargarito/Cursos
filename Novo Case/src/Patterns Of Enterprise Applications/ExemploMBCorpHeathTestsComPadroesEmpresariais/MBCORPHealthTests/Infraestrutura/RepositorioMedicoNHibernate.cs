using System.Collections.Generic;
using System.Linq;
using MBCORPHealthTests;
using MBCORPHealthTests.Infraestrutura;
using NHibernate.Linq;

namespace TestesUnitarios
{
    public class RepositorioMedicoNHibernate : IRepositorio<Medico>
    {
        public bool Gravar(Medico medico)
        {
            using (var session = NHibernateSessionFactory.Criar().OpenSession())
            {
                session.SaveOrUpdate(medico);
                session.Flush();
            }

            return true;
        }

        public List<Medico> ListarTodos()
        {
            using (var session = NHibernateSessionFactory.Criar().OpenSession())
            {
                return session.Query<Medico>().ToList();
            }

        }
    }
}