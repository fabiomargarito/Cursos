using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos.Repositorio;
using MBCorpHealth.Infraestrutura.Repositorio;
using NHibernate;

namespace MBCorpHealthUnitTest
{
    public interface ISessaoORM<T>
    {
        T RetornarSessao();
    }

    public class SessaoFake:ISessaoORM<ISessionFake>
    {
        public ISessionFake RetornarSessao()
        {
            throw new NotImplementedException();
        }
    }

    public interface ISessionFake
    {
    }

    public class SessaoNHibernate : ISessaoORM<ISession>
    {
        public ISession sessao { get; set; }

        public ISession  RetornarSessao()
        {
            return ConfiguracaoNHibernate.Criar().OpenSession();            
        }
    }

    public class Pacientes:IRepositorio<Paciente>
    {
        private ISession _iSession;
        

        public Pacientes(ISessaoORM<ISession> iSession)
        {
            _iSession = iSession.RetornarSessao();
        }      

        public bool Gravar(Paciente paciente)
        {
            _iSession.SaveOrUpdate(paciente);
            _iSession.Flush();                
            
            return true;
        }

        public IList<Paciente> retornarPorCPF(string CPF)
        {
            return null;
        }

        public List<Paciente> RetornarTodos()
        {
           return _iSession.QueryOver<Paciente>().List().ToList();            
        }

        public void InjetarDependencia(ISession isSession)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _iSession.Dispose();
        }
    }

    public class PacientesFake : IRepositorio<Paciente>
    {
        private ISession _iSession;


        public void Pacientes(ISessaoORM<ISessionFake> sessao)
        {
            
        }

        public void InjetarDependencia(ISession isSession)
        {
            
        }

        public bool Gravar(Paciente paciente)
        {
            

            return true;
        }

        public IList<Paciente> retornarPorCPF(string CPF)
        {
            return null;
        }

        public List<Paciente> RetornarTodos()
        {
            return null;
        }

        public void Dispose()
        {
            
        }
    }
}