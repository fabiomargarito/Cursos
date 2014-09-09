using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using HomeBrokerMBCorp.Dominio;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace HomeBrokerMBCorp.Infraestrutura.Persistencia
{
    public class ConfiguracaoNHibernate
    {
        public ISessionFactory CriarSessionFactory()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Mappings(mapeamento => mapeamento.FluentMappings.AddFromAssemblyOf<MapeamentoAcao>())
                .Mappings(mapeamento => mapeamento.FluentMappings.AddFromAssemblyOf<MapeamentoEmpresa>())
                .Mappings(mapeamento => mapeamento.FluentMappings.AddFromAssemblyOf<MapeamentoUsuario>())    
                .Database(                    
                    MsSqlConfiguration.MsSql2012.ConnectionString(conexao => conexao.FromConnectionStringWithKey("MBCORP")))
                   .ExposeConfiguration(config => new SchemaExport(config).SetOutputFile(@"C:\Users\Fabio\Dropbox\SchemaBancoDeDados.sql").Execute(true, true, false))
                    .BuildSessionFactory();

            return sessionFactory;
        }

    }

    public class MapeamentoAcao : ClassMap<Acao>
    {
        public MapeamentoAcao()
        {
            Id(chave => chave.Codigo).Column("CODIGOACAO");
            Map(campo => campo.Tipo).Column("TIPOACAO").Not.Nullable();            
            Table("ACAO");
        }
    }



    public class MapeamentoUsuario : ClassMap<Usuario>
    {
        public MapeamentoUsuario()
        {
            Id(chave => chave.CPF).Column("CPF");
            Map(campo => campo.Nome).Column("NOME").Not.Nullable();
            Table("USUARIO");
        }
    }

    public class MapeamentoEmpresa : ClassMap<Empresa>
    {

        public MapeamentoEmpresa()
        {
            Id(chave => chave.CNPJ).Column("CNPJ");
            Map(campo => campo.RazaoSocial).Column("RAZAOSOCIAL");
            HasMany(campo => campo.Acoes).KeyColumn("CNPJ").Cascade.SaveUpdate();
            Table("TBEMPRESA");
            
            
        }
    }

}
