using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace MBCORPHealthTests.Infraestrutura
{
    public class NHibernateSessionFactory
    {
        public static ISessionFactory Criar()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<MapeamentoEndereco>())
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<MapeamentoCredencialDeAcesso>())
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<MapeamentoPlanoDeSaude>())
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<MapeamentoPaciente>())   
                .Database(
                    MsSqlConfiguration.MsSql2008.ConnectionString(
                        c => c.FromConnectionStringWithKey("MBCORPHealthDB")))
                .ExposeConfiguration(config => new SchemaExport(config).SetOutputFile(@"C:\Users\Fabio\Dropbox\SchemaBancoDeDados.sql").Execute(true, true, false))
                .BuildSessionFactory();

            return sessionFactory;
        }
    }


    public class MapeamentoEndereco : ClassMap<Endereco>
    {
        public MapeamentoEndereco()
        {
            Id(chave => chave.ID).Column("IDENDERECO").GeneratedBy.Identity();
            Map(campo => campo.Cep).Column("CEP");
            Map(campo => campo.Logradouro).Column("LOGRADOURO");
            Map(campo => campo.Complemento).Column("COMPLEMENTO");
            Map(campo => campo.Bairro).Column("BAIRRO");
            Map(campo => campo.Cidade).Column("CIDADE");
            Map(campo => campo.Estado).Column("ESTADO");
            Table("ENDERECO");
            
        }
    }


    public class MapeamentoPlanoDeSaude : ClassMap<PlanoSaude>
    {
        public MapeamentoPlanoDeSaude()
        {
            Id(chave => chave.CNPJ).Column("CNPJ");
            Map(campo => campo.RazaoSocial).Column("RAZAOSOCIAL");            
            Table("PLANODESAUDE");
        }
    }

    public class MapeamentoCredencialDeAcesso : ClassMap<CredencialAcesso>
    {
        public MapeamentoCredencialDeAcesso()
        {
            Id(chave => chave.ID).Column("IDCREDENCIALACESSO").GeneratedBy.Identity();
            Map(campo => campo.NomeUsuario).Column("NOMEUSUARIO");
            Map(campo => campo.Senha).Column("SENHA");
            Table("CREDENCIALACESSO");
        }
    }



    public class MapeamentoPaciente : ClassMap<Paciente>
    {
        public MapeamentoPaciente()
        {
            Id(chave => chave.CPF).Column("CPF");
            Map(campo => campo.Nome).Column("NOME");
            References(campo => campo.Endereco).ForeignKey("IDENDERECO").Cascade.SaveUpdate();
            References(campo => campo.PlanoSaude).ForeignKey("CNPJ").Cascade.SaveUpdate();
            References(campo => campo.CredencialAcesso).ForeignKey("IDCREDENCIALACESSO").Cascade.SaveUpdate();
            Table("PACIENTE");
        }
    }

}
