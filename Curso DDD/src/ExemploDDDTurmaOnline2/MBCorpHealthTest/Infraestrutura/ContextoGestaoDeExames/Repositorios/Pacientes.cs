using System.Collections.Generic;
using System.Linq;
using MBCorpHealthTest.Dominio.Contratos.Repositorios;
using MBCorpHealthTest.Dominio.Entidades;
using NHibernate;
using NHibernate.Linq;

namespace MBCorpHealthTest.Infraestrutura.Repositorios
{
    public class Pacientes : IPacientes
    {
        private readonly ISession _session;

        public Pacientes(ISession session)
        {
            _session = session;
        }

        public IList<Paciente> ConsultarPacientesPorTrechoDoNome(string trechoDoNome)
        {

            return _session.Query<Paciente>().Where(campo => campo.Nome.Contains(trechoDoNome)).ToList();
           
        }

        public Paciente ConsultarPacientesPorCPF(string CPF)
        {
      
            return _session.Query<Paciente>().SingleOrDefault(campo => campo.CPF == CPF);
            
        }
    }
}