using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBCORPHealthTests.View;
using TestesUnitarios;

namespace MBCORPHealthTests.Dominio.Servico
{
    public class ServicoPersistenciaPaciente
    {
        public ServicoPersistenciaPaciente(IRepositorio<Paciente> repositorioPaciente)
        {
            this.repositorioPaciente = repositorioPaciente;
        }

        public IRepositorio<Paciente> repositorioPaciente { get; set; }
    

        public bool Gravar(PacienteDTO pacienteDto )
        {
            return repositorioPaciente.Gravar(new Paciente(pacienteDto.Nome, pacienteDto.CPF));
        }
    }
}
