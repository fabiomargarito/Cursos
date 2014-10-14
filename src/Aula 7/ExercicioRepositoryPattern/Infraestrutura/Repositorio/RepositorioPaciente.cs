using System;
using System.Collections.Generic;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos.Repositorio;

namespace MBCorpHealthUnitTest
{
    public class Pacientes:IRepositorio<Paciente>
    {
        public bool Gravar(Paciente paciente)
        {
            return true;
        }

        public IList<Paciente> retornarPorCPF(string CPF)
        {
            throw new NotImplementedException();
        }
    }
}