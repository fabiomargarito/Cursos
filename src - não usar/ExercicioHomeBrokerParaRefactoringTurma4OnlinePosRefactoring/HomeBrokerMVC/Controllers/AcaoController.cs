using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeBrokerMBCorp.Dominio;
using HomeBrokerMBCorp.Dominio.Contratos.Repositorio;
using HomeBrokerMBCorp.Infraestrutura.Persistencia;

namespace HomeBrokerMVC.Controllers
{
    public class AcaoController : Controller
    {
        // GET: Acao
        public ActionResult Index()
        {
            return View();
        }


        // GET: Acao
        public ActionResult ListarAcao()
        {
            IRepositorio<Empresa> repositorioAcao = new RepositorioEmpresaFake();
            return View(repositorioAcao.ListarTodos());
        }


        // GET: Acao
        public ActionResult Exluir()
        {
            return View();
        }
    }
}