using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AcaoPresenter
    {
        private IAcaoView _acaoView {get;set;}


        private Infraestrutura.IRepositorio<Acao> _repositorioAcao { get; set; }
        
        public AcaoPresenter(IAcaoView acaoView,Infraestrutura.IRepositorio<Acao> repositorioAcao)
        {
            _acaoView = acaoView;
            _repositorioAcao = repositorioAcao;
        }
        public List<Acao> acoes = new List<Acao>();
        public void retornarAcoes() { 
            List<Acao> acoes = new List<Acao>();            
            _acaoView.acoes = _repositorioAcao.ListarTodos().ToList();

        }
    }
}
