using Domain;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;

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
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<MapeamentoOperacao>())
                .Database(
                    MsSqlConfiguration.MsSql2008.ConnectionString(
                        "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DBHomeBroker;Data Source=Localhost;"))
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
            Not.LazyLoad();
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
