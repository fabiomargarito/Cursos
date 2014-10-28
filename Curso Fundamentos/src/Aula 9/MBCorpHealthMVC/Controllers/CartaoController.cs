using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FluentNHibernate.Testing.Values;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos.Repositorio;
using MBCorpHealth.Infraestrutura.Repositorio;
using NHibernate;
using NHibernate.Mapping;

namespace MBCorpHealthMVC.Controllers
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
            IRepositorio<Cartao> repositorioCartoes = new RepositorioCartao(_session);
            List<Cartao> cartoes = repositorioCartoes.RetornarTodos();
            return View(cartoes);
        }               
        
        public ActionResult Editar(string NumeroDoCartao)
        {
            return View();
        }

        
        public ActionResult Delete(int id)
        {
            return View();
        }
                
        public ActionResult Gravar()
        {            
                return View();           
        }

        
        [HttpPost]
        public ActionResult Gravar(Cartao cartao)
        {
            return View();
        }

    }
}
