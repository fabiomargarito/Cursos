using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBCORPHealthTests.View
{
    public interface IMedicoView
    {
        void ListarMedicos(IList<MedicoDto> medicos);
        event Action<MedicoDto> Gravar;
        event Action<MedicoDto> Excluir;
    }
}
