using System.Collections.Generic;
using System.Data;
using System.Linq;
using HomeBrokerMBCorp.Dominio;
using HomeBrokerMBCorp.Dominio.Contratos.Repositorio;

namespace HomeBrokerMBCorp.Infraestrutura.Persistencia
{
    public class RepositorioEmpresaNhiberante : IRepositorio<Empresa>
    {

        public void Gravar(Empresa empresa)
        {
            using (var session = (new ConfiguracaoNHibernate()).CriarSessionFactory().OpenSession())
            {
                session.SaveOrUpdate(empresa);
                session.Flush();
            }
        }

        public IList<Empresa> ListarTodos()
        {
            using (var session = (new ConfiguracaoNHibernate()).CriarSessionFactory().OpenSession())
            {
                using (var tran = session.BeginTransaction(IsolationLevel.ReadUncommitted))
                {
                    return session.QueryOver<Empresa>().List().ToList();
                }
            }
        }

        public Empresa RetornarPorID(string id)
        {
            using (var session = (new ConfiguracaoNHibernate()).CriarSessionFactory().OpenSession())
            {
                return session.QueryOver<Empresa>().Select(campo => campo.CNPJ == id).SingleOrDefault();
            }
        }
    }
}
