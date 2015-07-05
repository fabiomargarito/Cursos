using System;
using System.Collections.Generic;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos.Repositorio;
using NHibernate;

namespace MBCorpHealthUnitTest
{
    public class RepositorioPacienteMock : IRepositorio<Paciente>
    {
        public RepositorioPacienteMock(ISessaoORM<ISessionFake> sesso )
        {
        }

        public bool Gravar(Paciente paciente)
        {
            return true;
        }

        public IList<Paciente> retornarPorCPF(string CPF)
        {
            throw new NotImplementedException();
        }

        public List<Paciente> RetornarTodos()
        {
            throw new NotImplementedException();
        }

        public void InjetarDependencia(ISession isSession)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}