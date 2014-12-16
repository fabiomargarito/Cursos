using System.Collections.Generic;

namespace MBCorpHealth.Dominio.Contratos.Repositorio
{
    public interface IRepositorioAgendamento
    {
        List<Resultado> RetornarResultadosPorCPFDoPaciente(string CPF);
    }
}