using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBCorpHealth.Aplicacao.Servico;
using MBCorpHealth.Infraestrutura.Repositorio;
using MBCorpHealth.View;
using MBCorpHealth.View.ViewModel;
using NHibernate;

namespace MBCorpHealth.Presenter
{
   public  class CartaoPresenter
    {       
        private readonly IGravacaoCartao _gravacaoCartao;
        private readonly IListagemCartaoView _listagemCartaoView;

        public CartaoPresenter(IGravacaoCartao gravacaoCartao, IListagemCartaoView listagemCartaoView)
        {
            if (gravacaoCartao != null) gravacaoCartao.Gravar += gravacaoCartao_Gravar;

            
            _gravacaoCartao = gravacaoCartao;
            _listagemCartaoView = listagemCartaoView;
            
            
            
        }
        
        void gravacaoCartao_Gravar(CartaoViewModel cartao)
        {
            var servicoDeGestaoDeDadosDeCartao = new ServicoDeGestaoDeDadosDeCartao(new RepositorioCartao(ConfiguracaoNHibernate.Criar().OpenSession()));
            servicoDeGestaoDeDadosDeCartao.Gravar(cartao);
        }

        public void ListarCartoes()
        {
            var servicoDeGestaoDeDadosDeCartao = new ServicoDeGestaoDeDadosDeCartao(new RepositorioCartao(ConfiguracaoNHibernate.Criar().OpenSession()));
            IList<CartaoViewModel> cartoes = servicoDeGestaoDeDadosDeCartao.RetornarTodosOsCartoes();

            _listagemCartaoView.ExibirCartoes(cartoes);

        }

        



    }
}
