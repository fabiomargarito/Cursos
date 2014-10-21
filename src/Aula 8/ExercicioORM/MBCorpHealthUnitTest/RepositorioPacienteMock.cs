using System;
using System.Collections.Generic;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos.Repositorio;

namespace MBCorpHealthUnitTest
{
    public class RepositorioPacienteMock : IRepositorio<Paciente>
    {
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
    }
}