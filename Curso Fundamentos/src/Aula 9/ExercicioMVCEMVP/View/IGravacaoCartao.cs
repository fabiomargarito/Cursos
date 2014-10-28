using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBCorpHealth.View.ViewModel;

namespace MBCorpHealth.View
{
    public interface IGravacaoCartao
    {
        event Action<CartaoViewModel> Gravar;
    }
}
