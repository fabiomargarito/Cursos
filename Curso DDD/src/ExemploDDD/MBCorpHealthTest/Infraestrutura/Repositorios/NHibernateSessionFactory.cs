using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace MBCorpHealthTest.Infraestrutura.Repositorios
{
    public   class NHibernateSessionFactory
    {
        public   static ISessionFactory Criar()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<MapeamentoMedico>())                                
                .Database(                
                    MsSqlConfiguration.MsSql2008.ConnectionString(
                        c => c.FromConnectionStringWithKey("MBCORPHEALTH")))
                //.ExposeConfiguration(config => new SchemaExport(config).SetOutputFile(@"C:\Users\Fabio\Dropbox\Projetos\ArquivoSQLAulaDDD.sql").Execute(true, true, false))
                .BuildSessionFactory();

            return sessionFactory;
        }
    }
}
