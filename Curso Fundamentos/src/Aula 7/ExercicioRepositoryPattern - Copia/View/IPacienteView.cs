using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBCorpHealth.View.ViewModel;

namespace MBCorpHealth.View
{
    public interface IPacienteView
    {
        event Action<PacienteViewModel> Gravar;
        void ListarPacientes(List<PacienteViewModel> list);
    }
}
