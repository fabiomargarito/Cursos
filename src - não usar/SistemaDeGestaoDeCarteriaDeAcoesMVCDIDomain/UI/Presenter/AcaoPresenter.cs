using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using AutoMapper;
using Domain;
using Infraestrutura;
using UI.View;
using UI.View.ViewModel;

namespace UI.Presenter
{
    public class AcaoPresenter
    {
        private IAcaoView _acaoView {get;set;}


        private readonly Infraestrutura.IRepositorio<Acao> _repositorioAcao;
        
        public AcaoPresenter(IAcaoView acaoView)
        {
            _acaoView = acaoView;
            _repositorioAcao = new RepositorioAcaoEntity();
            _acaoView.Gravar+=_acaoView_Gravar;
            Mapper.CreateMap<Acao, AcaoViewModel>();
            Mapper.CreateMap<Empresa, EmpresaViewModel>();
            Mapper.CreateMap<EmpresaViewModel, Empresa>();
            Mapper.CreateMap<AcaoViewModel, Acao>().ForSourceMember(src => src.Empresas, member => member.Ignore());
                        
        }

        void _acaoView_Gravar(AcaoViewModel acao)
        {
            _repositorioAcao.Gravar(Mapper.Map<Acao>(acao));
            RetornarAcoes();
        }
                
     
        public void RetornarAcoes() {
            _acaoView.ListarAcoes( Mapper.Map<List<AcaoViewModel>>(_repositorioAcao.ListarTodos().ToList()));

        }
    }
}
