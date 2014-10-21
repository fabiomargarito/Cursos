using System.Collections.Generic;
using System.Linq;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos.Repositorio;
using NHibernate;
using NHibernate.Linq;

namespace MBCorpHealth.Infraestrutura.Repositorio
{
    public class RepositorioCartao : IRepositorio<Cartao>
    {
        private readonly ISession _session;

        public RepositorioCartao(ISession session)
        {
            _session = session;
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
    }

   
}