using System.Collections.Generic;
using MBCORPHealthTests;

namespace TestesUnitarios
{
    public class RepositorioMedico:IRepositorio<Medico>
    {
        public  bool Gravar(Medico medico)
        {
            return true;
        }
        public List<Medico> ListarTodos()
        {
            List<Medico> medicos = new List<Medico>();
            medicos.Add(new Medico("0001", "Medico 1"));
            medicos.Add(new Medico("002", "Medico 2"));
            return medicos;
        }
    }
}