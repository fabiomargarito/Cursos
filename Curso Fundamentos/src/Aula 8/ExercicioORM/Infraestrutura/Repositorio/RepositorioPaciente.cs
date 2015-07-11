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


        public void Dispose()
        {
            _iSession.Dispose();
        }
    }

    public class PacientesFake : IRepositorio<Paciente>
    {
        private ISessaoORM<ISessionFake> _iSession;


        public PacientesFake(ISessaoORM<ISessionFake> sessao)
        {
            _iSession = sessao;
        }


        public bool Gravar(Paciente paciente)
        {

            Console.Write("Paciente Fake, passei por aqui!!!!");
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