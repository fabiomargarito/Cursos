using System.Collections.Generic;
using MBCorpHealthTest.Dominio.Contratos.Repositorios;
using MBCorpHealthTest.Dominio.Entidades;

namespace MBCorpHealthTest.Infraestrutura.Repositorios
{
    public class PacientesFake : IPacientes
    {
        public IList<Paciente> ConsultarPacientesPorTrechoDoNome(string trechoDoNome)
        {
            IList<Paciente> listaDePacientes = new List<Paciente>(); 

            listaDePacientes.Add(new Paciente("123","Fabio"));
            listaDePacientes.Add(new Paciente("456", "João"));

            return listaDePacientes;
        }

        public Paciente ConsultarPacientesPorCPF(string CPF)
        {
            return new Paciente("1234","Fabio Margarito");
        }
    }
}