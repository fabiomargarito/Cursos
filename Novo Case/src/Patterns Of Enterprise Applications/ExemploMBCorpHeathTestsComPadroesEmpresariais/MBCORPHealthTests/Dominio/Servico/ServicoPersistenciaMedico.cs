using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBCORPHealthTests.View;
using TestesUnitarios;

namespace MBCORPHealthTests.Dominio.Servico
{
    public class ServicoPersistenciaMedico
    {
        public IRepositorio<Medico> repositorioMedico { get; set; }
        
        public ServicoPersistenciaMedico(IRepositorio<Medico> repositorioMedico)
        {
            this.repositorioMedico = repositorioMedico;
        }
        
        public bool Gravar(MedicoDto medicoDto)
        {
            return repositorioMedico.Gravar(new Medico(medicoDto.CRM, medicoDto.NOME));
        }


        public List<Medico> ListarTodos()
        {
            return repositorioMedico.ListarTodos();
        }
    }
}
