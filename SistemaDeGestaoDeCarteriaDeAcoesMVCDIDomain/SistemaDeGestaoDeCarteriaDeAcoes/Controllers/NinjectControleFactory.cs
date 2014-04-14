using System;
using System.Web.Mvc;
using System.Web.SessionState;
using Domain;
using FluentNHibernate.Infrastructure;
using Microsoft.Practices.Unity;
using Ninject;
using Ninject.Modules;
using SistemaDeGestaoDeCarteriaDeAcoes.Controllers;
using RequestContext = System.Web.Routing.RequestContext;

namespace Infraestrutura
{
    public class NinjectControleFactory : NinjectModule, IControllerFactory
    {
        private IKernel Container { get; set; }


        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            var kernel = new StandardKernel(new NinjectControleFactory());
            IController controller = kernel.Get<IController>(controllerName);            
            return controller;
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
           return System.Web.SessionState.SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            var disposable = controller as IDisposable;

            if (disposable != null)
            {
                disposable.Dispose();
            }
        }

        public override void Load()
        {
            Bind<IRepositorio<Acao>>().To<RepositorioAcaoNHibernate>();
            Bind<IRepositorio<Empresa>>().To<RepositorioEmpresaNHibernate>();
            Bind<IController>().To<AcaoController>().Named("Acao");
            Bind<IController>().To<HomeController>().Named("Home");
        }
    }
}