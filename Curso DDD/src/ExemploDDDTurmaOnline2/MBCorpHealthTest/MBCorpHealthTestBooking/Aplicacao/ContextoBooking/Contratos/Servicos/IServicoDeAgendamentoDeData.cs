using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBCorpHealthTestBooking.Aplicacao.ContextoBooking.Contratos.Servicos
{
    public interface IServicoDeAgendamentoDeData
    {
        IList<DateTime> retornarAgendaDisponivel(string cbhpm, string cnpjUnidadeDeDiagnostico);
    }
}
