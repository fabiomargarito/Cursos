using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using MBCorpHealth.Dominio;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace MBCorpHealth.Infraestrutura.Repositorio
{
    public class ConfiguracaoNHibernate
    {
        public static ISessionFactory Criar()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<MapeamentoCartao>())
                .Database(
                    MsSqlConfiguration.MsSql2012.ConnectionString(
                        c => c.FromConnectionStringWithKey("MBCorpDatabase")))
                //.ExposeConfiguration(config => new SchemaExport(config).SetOutputFile(@"C:\Users\Fabio\Dropbox\SchemaBancoDeDados.sql").Execute(true, true, false))
                .ExposeConfiguration(config => new SchemaUpdate(config).Execute(true,true)).BuildSessionFactory();
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

    public class MapeamentoPaciente : ClassMap<Paciente>
    {
        public MapeamentoPaciente()
        {            

            Id(chave => chave.CPF).Column("IDCPF");
            Map(campo => campo.Nome);
            Map(campo => campo.Apelido);
            References(chave => chave.Credencial).Column("IDCREDENCIAL");
            References(chave => chave.PlanoDeSaude).Column("IDPLANOSAUDE");
            Table("TBPACIENTE");            
        }
    }

    public class MapeamentoCredencial : ClassMap<Credencial>
    {
        public MapeamentoCredencial()
        {
            Id(chave => chave.ID).Column("IDCredencial");
            Map(campo => campo.NomeDeUsuario);
            Map(campo => campo.Senha);
            Table("TBCREDENCIAL");            
        }
    }

    public class MapeamentoPlanoDeSaude : ClassMap<PlanoDeSaude>
    {
        public MapeamentoPlanoDeSaude()
        {
            Id(chave => chave.CNPJ);
            Map(campo => campo.NomePlano);
            Map(campo => campo.TipoDoPlano);
            Table("TBPLANODESAUDE");
        }
    }

}
