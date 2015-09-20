using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace JBSMedical.Infraestrutura.Repositorios
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
                .ExposeConfiguration(config => new SchemaExport(config).SetOutputFile(@"C:\Users\Fabio\Dropbox\Treinamentos\ExemplosModulo2\Curso DDD\src\Turma2JBSDDD\Script\jbsturma2.sql").Execute(true, true, false))
                .BuildSessionFactory();

            return sessionFactory;
        }
    }

}
