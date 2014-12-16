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
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<MapeamentoPaciente>())
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<MapeamentoPlanoDeSaude>())
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<MapamentoCredencial>())
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(c => c.FromConnectionStringWithKey("BDMBCORP")))
                //.ExposeConfiguration(
                //    config =>
                //        new SchemaExport(config).SetOutputFile(@"c:\users\fabio\dropbox\SchemaBancoDeDados.sql")
                //            .Execute(true, true, false))
                .BuildSessionFactory();
                

            return sessionFactory;
        }
    }

    public class MapeamentoPaciente : ClassMap<Paciente>
    {
        public MapeamentoPaciente()
        {
            Id(chave => chave.CPF).Column("NOCPF").Not.Nullable();
            Map(campo => campo.Nome).Column("NMNome").Not.Nullable();
            References(campo => campo.Credencial).Column("IDCredencial").Cascade.SaveUpdate();
            References(campo => campo.PlDeSaude).Column("IDPlanoSaude").Cascade.SaveUpdate();
            Table("TBPaciente");
        }
    }

    public class MapeamentoPlanoDeSaude : ClassMap<PlanoDeSaude>
    {
        public MapeamentoPlanoDeSaude()
        {
            Id(chave => chave.CNPJ).Not.Nullable();
            Map(campo => campo.NomePlano).Column("NMPlano");
            Map(campo => campo.TipoDoPlano).Column("TPPlano");
            Table("TbPlanoSaude");
        }
    }

    public class MapamentoCredencial : ClassMap<Credencial>
    {
        public MapamentoCredencial()
        {
            Id(chave => chave.IDCredencial).Not.Nullable().GeneratedBy.Identity();
            Map(campo => campo.NomeDeUsuario).Column("NMUsuario");
            Map(campo => campo.Senha).Column("Senha");
            Table("TbCredencial");
        }
    }

}
