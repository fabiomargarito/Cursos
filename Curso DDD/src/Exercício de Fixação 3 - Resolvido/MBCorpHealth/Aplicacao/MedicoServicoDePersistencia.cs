using MBCorpHealth.Dominio;

namespace MBCorpHealth.Aplicacao
{
    public class MedicoServicoDePersistencia
    {
        private bool Gravar(Medico medico)
        {
            var repositorioAgendamento = new RepositorioAgendamento();
            return repositorioAgendamento.GravarMedico(medico);
            
        }
    }
}
