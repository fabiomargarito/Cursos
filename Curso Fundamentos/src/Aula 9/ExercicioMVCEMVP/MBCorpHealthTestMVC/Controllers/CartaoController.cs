using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MBCorpHealth.Aplicacao.Servico;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos.Repositorio;
using MBCorpHealth.Infraestrutura.Repositorio;
using MBCorpHealth.View.ViewModel;
using NHibernate;

namespace MBCorpHealthTestMVC.Controllers
{
    public class CartaoController : Controller
    {
        private ISession _session;
        // GET: Cartao
        public CartaoController()
        {
               _session = (ISession) System.Web.HttpContext.Current.Items["session"];

            
        }

        public ActionResult Index()
        {
            //Logica de consulta
            var servicoDeGestaoDeDadosDeCartao = new ServicoDeGestaoDeDadosDeCartao(new RepositorioCartao(_session));
            IList<CartaoViewModel> cartoes = servicoDeGestaoDeDadosDeCartao.RetornarTodosOsCartoes();

            return View(cartoes);
        }


        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Criar(CartaoViewModel cartao)
        {

            var servicoDeGestaoDeDadosDeCartao = new ServicoDeGestaoDeDadosDeCartao(new RepositorioCartao(_session));
            servicoDeGestaoDeDadosDeCartao.Gravar(cartao);
            return View("Sucesso");
        }

        public ActionResult Editar(string numerodocartao)
        {
            throw new NotImplementedException();
        }
    }
}
