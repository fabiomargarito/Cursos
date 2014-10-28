using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using MBCorpHealth.Dominio;
using NHibernate;
using NHibernate.Mapping;
using NHibernate.Tool.hbm2ddl;

namespace MBCorpHealth.Infraestrutura.Repositorio
{
    public class ConfiguracaoNHibernate
    {
        public static ISessionFactory Criar()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Mappings(map=>map.FluentMappings.AddFromAssemblyOf<MapeamentoCartao>())                                
                .Database(
                    MsSqlConfiguration.MsSql2008.ConnectionString(
                        c => c.FromConnectionStringWithKey("MBCorpDatabase")))
                 .ExposeConfiguration(config => new SchemaExport(config).SetOutputFile(@"C:\Users\Fabio\Dropbox\SchemaBancoDeDados.sql").Execute(true, true, false))
                        .BuildSessionFactory();

            return sessionFactory;
        }
    }

    class MapeamentoCartao:ClassMap<Cartao>
    {
        public MapeamentoCartao()
        {
            Id(chave => chave.NumeroDoCartao).Column("NOCartao").CustomSqlType("Varchar(100)");
            Map(campo => campo.CodigoDeSeguranca).Column("CodSeguranca");
            Map(campo => campo.NomeConformeEscritoNoCartao).Column("NmEscrito");
            Table("TBCartao");            
        }
    }


}
