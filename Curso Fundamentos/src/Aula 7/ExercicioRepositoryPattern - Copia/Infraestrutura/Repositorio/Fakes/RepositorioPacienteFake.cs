using System.Collections.Generic;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos;

namespace MBCorpHealth.Infraestrutura.Repositorio.Fakes
{
    public class RepositorioPacienteFake:IRepositorioPaciente
    {
        public bool Gravar(Paciente paciente)
        {            
            return true;
        }

        public List<Paciente> RetornarPorTrechoNome(string fa)
        {
            List<Paciente> pacientes = new List<Paciente>();
            Paciente paciente = new Paciente("Fabio Margarito","123434535");
            pacientes.Add(paciente);
            return pacientes;

        }

        public bool Excluir(Paciente paciente)
        {
            return true;
        }
    }
}