using System.Collections.Generic;
using MBCorpHealth.Dominio;

namespace MBCorpHealth.Aplicacao
{
    public interface IRepositorioAgendamento
    {
        bool GravarMedico(Medico medico);
        List<Medico> ListarMedicos();
        List<Medico> ListarMedicosPorNome(string nome);
    }
}