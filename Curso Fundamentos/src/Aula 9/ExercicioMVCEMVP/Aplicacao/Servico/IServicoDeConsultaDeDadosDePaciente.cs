using System.Collections.Generic;

namespace MBCorpHealth.Aplicacao.Servico
{
    public interface IServicoDeConsultaDeDadosDePaciente
    {
        IList<ResultadoViewModel> RetornarResultadosDeExame(string CPF);
    }
}