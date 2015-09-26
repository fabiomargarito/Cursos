using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using JBSMedical.Infraestrutura.Repositorios;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace JBSMedical.CadastrosBoundedContext.Infraestrutura.Repositorios
{
    public class NHibernateSessionFactory
    {
        public static ISessionFactory Criar()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<MapeamentoAgendamento>())
                .Database(                 
                    MsSqlConfiguration.MsSql2012.ConnectionString(
                        conexao => conexao.FromConnectionStringWithKey("JBSTurma2")))
                .ExposeConfiguration(config => new SchemaExport(config).SetOutputFile(@"jbsturma2.sql").Execute(true, true, false))
                .BuildSessionFactory();

            return sessionFactory;
        }
    }

}
