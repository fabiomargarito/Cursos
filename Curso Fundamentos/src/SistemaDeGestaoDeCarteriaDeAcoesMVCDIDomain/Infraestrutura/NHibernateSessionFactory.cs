using Domain;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Linq;
using NHibernate.Tool.hbm2ddl;

namespace Infraestrutura
{
    public  class NHibernateSessionFactory
    {
        public static ISessionFactory Criar()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<MapeamentoAcao>())
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<MapeamentoEmpresa>())
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<MapeamentoOperacao>())
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<MapeamentoCarteira>())
                
                .Database(                    
                    MsSqlConfiguration.MsSql2008.ConnectionString(
                        c=>c.FromConnectionStringWithKey("GestaoDeCarteiraDBContext")))
                //.ExposeConfiguration(config => new SchemaExport(config).SetOutputFile(@"C:\Users\Fabio\Dropbox\SchemaBancoDeDados.sql").Execute(true, true, false))
                        .BuildSessionFactory();

            return sessionFactory;
        }
    }


    public class MapeamentoEmpresa : ClassMap<Empresa>
    {
        public MapeamentoEmpresa()
        {
            
            Id(chave => chave.CNPJEmpresa).Column("CNPJ");
            Map(campo => campo.Razaosocial).Column("RAZAOSOCIAL");                                    
            Not.LazyLoad();
        }
    }
    public class MapeamentoAcao : ClassMap<Acao>
    {
        public MapeamentoAcao()
        {
            Id(chave => chave.Codigo).Column("CODIGO");
            References(chave => chave.Empresa).Column("CNPJ");
            Table("ACAO");            
            LazyLoad();
        }
    }
    public class MapeamentoOperacao : ClassMap<Operacao>
    {
        public MapeamentoOperacao()
        {
            Id(chave => chave.ID).Column("ID").GeneratedBy.Identity();
            Map(campo => campo.Valor).Column("VALOR");
            Map(campo => campo.Data).Column("DATA");
            Map(campo => campo.Quantidade).Column("QUANTIDADE");
            Map(campo => campo.Tipo).Column("TIPO");
            References(campo => campo.Acao).Column("CODIGO");
            Not.LazyLoad();
        }

       

    }
    public class MapeamentoCarteira : ClassMap<Carteira>
    {
        public MapeamentoCarteira()
        {
            Id(chave => chave.ID).Column("ID").GeneratedBy.Assigned();
            HasMany(operacao => operacao.Operacoes).KeyColumn("ID_CARTEIRA").Cascade.SaveUpdate();
            Not.LazyLoad();
        }
    }
}
