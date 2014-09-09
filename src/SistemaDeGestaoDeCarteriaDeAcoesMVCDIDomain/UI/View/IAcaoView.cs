using System;
using System.Collections.Generic;
using Domain;
using UI.View.ViewModel;

namespace UI.View
{
    public interface IAcaoView{
        void ListarAcoes(IList<AcaoViewModel> acoes);
        event Action<AcaoViewModel> Gravar;
        event Action<AcaoViewModel> Excluir;
    }
}
