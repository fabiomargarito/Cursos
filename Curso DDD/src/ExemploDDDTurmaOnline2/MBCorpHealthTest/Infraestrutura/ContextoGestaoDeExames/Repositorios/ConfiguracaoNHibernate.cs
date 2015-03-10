using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace MBCorpHealthTest.Infraestrutura.Repositorios
{
    public class ConfiguracaoNHibernate
    {
        public class NHibernateSessionFactory
        {
            public static ISessionFactory Criar()
            {
                ISessionFactory sessionFactory = Fluently.Configure()
                    .Mappings(map => map.FluentMappings.AddFromAssemblyOf<MapeamentoPaciente>())
                    .Database(                  
                        MsSqlConfiguration.MsSql2012.ConnectionString(
                            conexao => conexao.FromConnectionStringWithKey("MBCORPHEALTH")))
                   // .ExposeConfiguration(config => new SchemaExport(config).SetOutputFile(@"C:\DDDTurma2\DDL.SQL").Execute(true, true, false))
                    .BuildSessionFactory();

                return sessionFactory;
            }
        }
    }
}
