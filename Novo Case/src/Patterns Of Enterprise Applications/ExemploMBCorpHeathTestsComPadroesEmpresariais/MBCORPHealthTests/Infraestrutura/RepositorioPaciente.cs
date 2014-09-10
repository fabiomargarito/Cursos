using System.Collections.Generic;
using MBCORPHealthTests;

namespace TestesUnitarios
{
    public class RepositorioPaciente:IRepositorio<Paciente>
    {
        public bool Gravar(Paciente paciente)
        {
            return true;
        }
        public List<Paciente> ListarTodos()
        {
            List<Paciente> pacientes = new List<Paciente>(); 
            pacientes.Add(new Paciente("FAbio 1","123"));
            pacientes.Add(new Paciente("FAbio 2", "456"));
            return pacientes;
        }
    }
}