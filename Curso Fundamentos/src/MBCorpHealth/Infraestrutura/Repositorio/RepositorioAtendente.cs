using MBCorpHealth.Infraestrutura.Repositorio;
using NHibernate;
using System;
using System.Collections.Generic;

namespace ExemploDeCriacaoDeUmRepositorioTurma4
{
    public class RepositorioAtendente : IRepositorioAtendente
    {
        private ISession _sessaoNHibernate;

        public RepositorioAtendente(ISession sessaoNHibenrante) {
            _sessaoNHibernate = sessaoNHibenrante;
        }

        public Atendente retornarPorCPF(string cpf)
        {
            Atendente atendente;

               atendente = _sessaoNHibernate.QueryOver<Atendente>().Where(criterio=>criterio.CPF==cpf).SingleOrDefault();                           

            return atendente;
        }
        public bool Excluir(Atendente atendente)
        {

                _sessaoNHibernate.Delete(atendente);
                _sessaoNHibernate.Flush();
   
            return true;
        }
        public  bool Gravar(Atendente atendente)
        {
            
                _sessaoNHibernate.SaveOrUpdate(atendente);
                _sessaoNHibernate.Flush();
            
            return true;
        }
        public IList<Atendente> retornarTodos()
        {
            IList<Atendente> atendentes;
            atendentes = _sessaoNHibernate.QueryOver<Atendente>().List<Atendente>();            
            return atendentes;

        }
    }
}