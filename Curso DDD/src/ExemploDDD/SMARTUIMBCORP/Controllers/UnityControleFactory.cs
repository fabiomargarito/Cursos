using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Contratos;
using MBCorpHealthTest.Infraestrutura.ContextoAdministracaoDeAgendamentosDeExame.Repositorios;
using MBCorpHealthTest.Infraestrutura.ContextoCadastrosCorporativos;
using Microsoft.Practices.Unity;
using NHibernate;

namespace SMARTUIMBCORP.Controllers
{
    public class UnityControleFactory : IControllerFactory
    {
        private UnityContainer Container { get; set; }

        public UnityControleFactory()
        {

            this.Container = new UnityContainer();

            var session = NHibernateSessionFactory.Criar().OpenSession();
            this.Container.RegisterInstance<ISession>(session);
            Container.RegisterType<IMedicos, MedicosFake>();     
               
            this.Container.RegisterType(typeof(IController), typeof(MedicoController),"Medico");
            this.Container.RegisterType(typeof(IController), typeof(HomeController), "Home");
            this.Container.RegisterType(typeof(IController), typeof(AccountController), "Account");            
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
