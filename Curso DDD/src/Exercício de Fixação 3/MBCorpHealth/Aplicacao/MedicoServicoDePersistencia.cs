using System.Collections.Generic;
using System.Linq;
using MBCorpHealth.Dominio;

namespace MBCorpHealth.Aplicacao
{
    public class MedicoServicoDePersistencia
    {
        private readonly IRepositorioAgendamento _repositorioAgendamento;

        public MedicoServicoDePersistencia(IRepositorioAgendamento repositorioAgendamento)
        {
            _repositorioAgendamento = repositorioAgendamento;
        }

        public  bool Gravar(MedicoViewModel medico)
        {
            IRepositorioAgendamento repositorioAgendamento = _repositorioAgendamento;
            return repositorioAgendamento.GravarMedico(new Medico(medico.Nome,"null",medico.CRM));            
        }



        public List<MedicoViewModel> ListarMedicos ()
        {
            IRepositorioAgendamento repositorioAgendamento = _repositorioAgendamento;
            return repositorioAgendamento.ListarMedicos().Select(medico => new MedicoViewModel {CRM = medico.Conselho, Nome = medico.Nome}).ToList();
        }
    }
}
