using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Domain;
using FluentNHibernate.Automapping;
using Infraestrutura;
using Microsoft.Ajax.Utilities;
using Ninject;
using UI.View;
using UI.View.ViewModel;

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

            Mapper.CreateMap<Acao, AcaoViewModel>();
            Mapper.CreateMap<Empresa, EmpresaViewModel>();
            Mapper.CreateMap<EmpresaViewModel, Empresa>();
            Mapper.CreateMap<AcaoViewModel, Acao>().ForSourceMember(src => src.Empresas, member => member.Ignore());
                        

        }

        public ActionResult Index()
        {
            
            var acoesAcaoViewModels = Mapper.Map<List<AcaoViewModel>>(_acaoRepositorio.ListarTodos());

            return View(acoesAcaoViewModels);
        }
    
        public ActionResult AdicionarAcao()
        {
            var acaoViewModel = new AcaoViewModel
            {
                Empresas = Mapper.Map<List<EmpresaViewModel>>(_empresaRepositorio.ListarTodos())
            };


            return View(acaoViewModel);
        }

        [HttpPost]
        public ActionResult AdicionarAcao(AcaoViewModel acao)
        {
            
            

            Acao a = Mapper.Map<Acao>(acao);

            _acaoRepositorio.Gravar(a);
            
            return RedirectToAction("Index");
        }
        
        public ActionResult ExcluirAcao(string codigo)
        {            
            _acaoRepositorio.Excluir(_acaoRepositorio.RetornarPorID(codigo));
            return RedirectToAction("Index");
        }
        

   

    }
}
