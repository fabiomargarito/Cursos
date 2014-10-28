using System.Collections.Generic;
using System.Linq;
using MBCorpHealth.Dominio;
using MBCorpHealth.Infraestrutura.Repositorio;
using MBCorpHealth.View.ViewModel;

namespace MBCorpHealth.Aplicacao.Servico
{
    public class ServicoDeGestaoDeDadosDeCartao
    {
        private readonly RepositorioCartao _repositorioCartaoMock;

        public ServicoDeGestaoDeDadosDeCartao(RepositorioCartao repositorioCartaoMock)
        {
            _repositorioCartaoMock = repositorioCartaoMock;
        }

        public IList<CartaoViewModel> RetornarTodosOsCartoes()
        {
            IList<Cartao> retorno = _repositorioCartaoMock.RetornarTodos();

            IList<CartaoViewModel> cartaoViewModels = retorno.Select(cartao => new CartaoViewModel {NumeroDoCartao = cartao.NumeroDoCartao, CodigoDeSeguranca = cartao.CodigoDeSeguranca, NomeConformeEscritoNoCartao = cartao.NomeConformeEscritoNoCartao}).ToList();

            return cartaoViewModels;
        }

        public bool Gravar(CartaoViewModel cartao)
        {
            return    _repositorioCartaoMock.Gravar(new Cartao(cartao.NumeroDoCartao,cartao.NomeConformeEscritoNoCartao,cartao.CodigoDeSeguranca));
        }
    }
}