using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;
using Infraestrutura;
using Microsoft.Ajax.Utilities;
using Ninject;

namespace SistemaDeGestaoDeCarteriaDeAcoes.Controllers
{
    public class AcaoController : Controller
    {

        private IRepositorio<Acao> _acaoRepositorio;
        private IRepositorio<Empresa> _empresaRepositorio;

        public AcaoController(IRepositorio<Acao> acaRepositorio,IRepositorio<Empresa> empresaRepositorio )
        {
            _acaoRepositorio = acaRepositorio;
            _empresaRepositorio = empresaRepositorio;

        }

        public ActionResult Index()
        {
            return View(_acaoRepositorio.ListarTodos());
        }
    
        public ActionResult AdicionarAcao()
        {
            AcaoViewModel acaoViewModel = new AcaoViewModel();
            acaoViewModel.Empresas = _empresaRepositorio.ListarTodos();
            return View(acaoViewModel);
        }

        [HttpPost]
        public ActionResult AdicionarAcao(Acao acao)
        {
            _acaoRepositorio.Gravar(acao);
            return RedirectToAction("Index");
        }

        
        public ActionResult ExcluirAcao(string codigo)
        {            
            _acaoRepositorio.Excluir(_acaoRepositorio.RetornarPorID(codigo));
            return RedirectToAction("Index");
        }
        

       public class AcaoViewModel
       {
           public Acao Acao;
           public IEnumerable<Empresa> Empresas;
       }


    }
}
