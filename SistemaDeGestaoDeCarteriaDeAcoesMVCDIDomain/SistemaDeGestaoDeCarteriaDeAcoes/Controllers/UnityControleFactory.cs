using System.Web.Mvc;
using System.Web.SessionState;
using Domain;
using FluentNHibernate.Infrastructure;
using Microsoft.Practices.Unity;
using SistemaDeGestaoDeCarteriaDeAcoes.Controllers;
using RequestContext = System.Web.Routing.RequestContext;

namespace Infraestrutura
{
    public class UnityControleFactory : IControllerFactory
    {
        private UnityContainer Container { get; set; }

        public UnityControleFactory()
        {

            this.Container = new UnityContainer();
            this.Container.RegisterType(typeof(IRepositorio<Acao>), typeof(RepositorioAcaoEntity));
            this.Container.RegisterType(typeof(IRepositorio<Empresa>), typeof(RepositorioEmpresaEntity));
            this.Container.RegisterType(typeof(IController), typeof(AcaoController),"Acao");
            this.Container.RegisterType(typeof(IController), typeof(HomeController),"Home");
        }

        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            IController controller = Container.Resolve<IController>(controllerName);            
            return controller;
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
           return System.Web.SessionState.SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
          Container.Teardown(controller);
        }
    }
}
