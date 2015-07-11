using MBCorpHealth.Infraestrutura.Repositorio;
using NHibernate;

namespace MBCorpHealthUnitTest
{
    public class SessaoNHibernate : ISessaoORM<ISession>
    {
        public ISession sessao { get; set; }

        public ISession  RetornarSessao()
        {
            return ConfiguracaoNHibernate.Criar().OpenSession();            
        }
    }
}