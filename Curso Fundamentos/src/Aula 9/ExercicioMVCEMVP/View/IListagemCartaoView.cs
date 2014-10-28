using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MBCorpHealth.View.ViewModel;

namespace MBCorpHealth.View
{
    public interface IListagemCartaoView
    {
        void ExibirCartoes(IList<CartaoViewModel> cartoes);
    }
}
