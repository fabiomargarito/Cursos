using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace JBSHealthCare.Infraestrutura.Repositorio
{
    public class NHibernateSessionFactory
    {
        public static ISessionFactory Criar()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<MapeamentoCID>())
                .Database(
                    MsSqlConfiguration.MsSql2012.ConnectionString(
                        conexao => conexao.FromConnectionStringWithKey("JBS")))
                //.ExposeConfiguration(config => new SchemaExport(config).SetOutputFile(@"C:\Users\Fabio\Dropbox\Treinamentos\ExemplosModulo2\Curso DDD\src\Turma1JBSDDD\Scripts\Script.sql").Execute(true, true, false))
                .BuildSessionFactory();

            return sessionFactory;
        }
    }
}