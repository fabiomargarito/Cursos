using ExemploDeCriacaoDeUmRepositorioTurma4;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBCorpHealth.Infraestrutura.Repositorio
{
    public class ConfiguracaoNHibernate
    {
        public static ISessionFactory Criar()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<MapeamentoAtendente>())
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(
                        c => c.FromConnectionStringWithKey("MBCorpDatabase"))
                    )
                .ExposeConfiguration(config => new SchemaUpdate(config).Execute(true, true)).BuildSessionFactory();
            return sessionFactory;
        }       
    }

    class MapeamentoAtendente : ClassMap<Atendente> {
        public MapeamentoAtendente() {
            Id(chave=>chave.CPF).Column("NO_CPF");
            Map(propriedade => propriedade.Nome).Column("NM_NOME");
            Map(propriedade => propriedade.DataDeNascimento).Column("DT_NASCIMENTO");
            Table("TB_ATENDENTE");
        }
    }
}
