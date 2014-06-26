using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Linq;

namespace Infraestrutura
{
    public partial class RepositorioEmpresaFake : IRepositorio<Empresa>
    {
        public void Gravar(Empresa entidade)
        {
            throw new NotImplementedException();
        }
        public Empresa RetornarPorID(int identificador)
        {
            throw new NotImplementedException();
        }
        public Empresa RetornarPorID(string identificador)
        {
            throw new NotImplementedException();
        }
        public IList<Empresa> ListarTodos()
        {
            List<Empresa> empresas = new List<Empresa>();
            empresas.Add(new Empresa {CNPJEmpresa = "1", Razaosocial = "PETROBRAS"});
            empresas.Add(new Empresa {CNPJEmpresa = "1", Razaosocial = "VALE"});

            return empresas;
        }
        public void Excluir(Empresa entidade)
        {
            throw new NotImplementedException();
        }
    }
    public class RepositorioEmpresaEntity:IRepositorio<Empresa>
    {

         private GestaoDeCarteiraDBContext _contextoDeBancoDeDados;

         public RepositorioEmpresaEntity(GestaoDeCarteiraDBContext contextoDeBancoDeDados)
        {
            _contextoDeBancoDeDados = contextoDeBancoDeDados;
        }

        public void Gravar(Empresa entidade)
        {
            _contextoDeBancoDeDados.Empresa.Add(entidade);
            _contextoDeBancoDeDados.SaveChanges();
        }

        public Empresa RetornarPorID(int identificador)
        {
            throw new NotImplementedException();
        }

        public Empresa RetornarPorID(string identificador)
        {
            return _contextoDeBancoDeDados.Empresa.SingleOrDefault(empresa => empresa.CNPJEmpresa == identificador);
            
        }

        public IList<Empresa> ListarTodos()
        {
            return _contextoDeBancoDeDados.Empresa.ToList();
        }

        public void Excluir(Empresa entidade)
        {
            _contextoDeBancoDeDados.Empresa.Remove(RetornarPorID(entidade.CNPJEmpresa));
            _contextoDeBancoDeDados.SaveChanges();
        }
    }
    public class RepositorioEmpresaNHibernate : IRepositorio<Empresa>
    {
    

        public void Gravar(Empresa entidade)
        {
            using (ISession session = NHibernateSessionFactory.Criar().OpenSession())
            {
                session.Save(entidade);
            }
        }

        public Empresa RetornarPorID(int identificador)
        {
            throw new NotImplementedException();
        }

        public Empresa RetornarPorID(string identificador)
        {
            using (ISession session = NHibernateSessionFactory.Criar().OpenSession())
            {
                return session.Query<Empresa>().SingleOrDefault(empresa => empresa.CNPJEmpresa == identificador);
            }
        }

        public IList<Empresa> ListarTodos()
        {
            using (ISession session = NHibernateSessionFactory.Criar().OpenSession())
            {
                return session.Query<Empresa>().ToList();
            }
        }

        public void Excluir(Empresa entidade)
        {
            using (ISession session = NHibernateSessionFactory.Criar().OpenSession())
            {
                 session.Delete(entidade);
            }
            
        }
    }
}