using System.Collections.Generic;
using System.Linq;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos.Repositorio;
using MBCorpHealthUnitTest;
using NHibernate;
using NHibernate.Linq;

namespace MBCorpHealth.Infraestrutura.Repositorio
{
    public class RepositorioCartao : IRepositorio<Cartao>
    {
        private readonly ISession _session;

        public RepositorioCartao(ISessaoORM<ISession> session)
        {
            _session = session.RetornarSessao() as ISession;
        }

        public bool Gravar(Cartao entidade)
        {

            _session.SaveOrUpdate(entidade);
            _session.Flush();
            

            return true;
        }

        public IList<Cartao> retornarPorCPF(string CPF)
        {
            throw new System.NotImplementedException();
        }

        public List<Cartao> RetornarTodos()
        {        
           return _session.Query<Cartao>().ToList();            
        }

        public void InjetarDependencia(ISession isSession)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }

   
}