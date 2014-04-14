using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Linq;

namespace Infraestrutura
{
    public partial class RepositorioAcaoFake : IRepositorio<Acao>
    {
        private IList<Acao> acoes = new List<Acao>();

        public void Gravar(Acao entidade)
        {
            acoes.Add(entidade);


        }

        public Acao RetornarPorID(int identificador)
        {
            throw new NotImplementedException();
        }

        public Acao RetornarPorID(string identificador)
        {
            throw new NotImplementedException();
        }

        public IList<Acao> ListarTodos()
        {

            acoes.Add(new Acao {Codigo = "PETR4", Empresa = new Empresa {CNPJEmpresa = "1", Razaosocial = "PETROBRAS"}});
            acoes.Add(new Acao {Codigo = "PETR3", Empresa = new Empresa {CNPJEmpresa = "1", Razaosocial = "PETROBRAS"}});

            return acoes;
        }

        public void Excluir(Acao acao)
        {
            throw new NotImplementedException();
        }
    }

    public class RepositorioAcaoEntity : IRepositorio<Acao>
    {
        private GestaoDeCarteiraDBContext _contextoDeBancoDeDados;

        public RepositorioAcaoEntity(GestaoDeCarteiraDBContext contextoDeBancoDeDados)
        {
            _contextoDeBancoDeDados = contextoDeBancoDeDados;
        }

        public void Gravar(Acao entidade)
        {
            entidade.Empresa =
                _contextoDeBancoDeDados.Empresa.SingleOrDefault(
                    empresa => empresa.CNPJEmpresa == entidade.Empresa.CNPJEmpresa);                        
            _contextoDeBancoDeDados.Acao.Add(entidade);
            _contextoDeBancoDeDados.SaveChanges();
            _contextoDeBancoDeDados.Dispose();
        }

        public Acao RetornarPorID(int identificador)
        {            
                   throw new NotImplementedException();
        }

        public Acao RetornarPorID(string identificador)
            {
                return _contextoDeBancoDeDados.Acao.SingleOrDefault(acao => acao.Codigo == identificador);
       
        }

        public IList<Acao> ListarTodos()
        {
            return _contextoDeBancoDeDados.Acao.ToList();            
        }

        public void Excluir(Acao entidade)
        {
            _contextoDeBancoDeDados.Acao.Remove(RetornarPorID(entidade.Codigo));
            _contextoDeBancoDeDados.SaveChanges();
        }
    }

    public class RepositorioAcaoNHibernate : IRepositorio<Acao>
    {
       
   
        public void Gravar(Acao entidade)
        {
            using (ISession session = NHibernateSessionFactory.Criar().OpenSession())
            {
                session.Save(entidade);
                session.Flush();
            }
        }

        public Acao RetornarPorID(int identificador)
        {
            throw new NotImplementedException();
        }

        public Acao RetornarPorID(string identificador)
        {
            using (ISession session = NHibernateSessionFactory.Criar().OpenSession())
            {
                return session.Query<Acao>().SingleOrDefault(acao => acao.Codigo == identificador);
            }
        }

        public IList<Acao> ListarTodos()
        {
            using (ISession session = NHibernateSessionFactory.Criar().OpenSession())
            {
                return session.Query<Acao>().Select(acao => acao).ToList();
            }
        }

        public void Excluir(Acao entidade)
        {
            using (ISession session = NHibernateSessionFactory.Criar().OpenSession())
            {
                 session.Delete(entidade);
                 session.Flush();
            }
            
        }
    }


    
}
