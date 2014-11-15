using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using MBCorpHealth.Dominio;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace MBCorpHealth.Infraestrutura
{
    public class ConfiguracaoNHibernate
    {
        public static ISessionFactory Criar()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
            //Configura o banco de dados
            .Mappings(map => map.FluentMappings.
                AddFromAssemblyOf<MapeamentoMedico>())                                                   
            .Database(            
            MsSqlConfiguration.MsSql2012.ConnectionString(
                        c => c.FromConnectionStringWithKey("MBCorpDatabase")))            
                        //.ExposeConfiguration(config => new SchemaExport(config)
                        //.SetOutputFile(@"C:\Users\Fabio\Dropbox\SchemaBancoDeDados.sql")
                       // .Execute(true, true, false))
                        .BuildSessionFactory();
                        return sessionFactory;        
                
                
                
        }
    }

    public class MapeamentoMedico : ClassMap<Medico>
    {
        public MapeamentoMedico()
        {
            Id(chave => chave.CPF).Column("NOCPF");
            Map(campo => campo.Nome).CustomSqlType("varchar(100)");
            Map(campo => campo.Conselho).Column("CRM");
            Table("TBMEDICO");
        }
    }



}
