using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using System.Web.UI;
using MBCorpHealthTest.Infraestrutura.Repositorios;
using MBCorpHealthTestTests;
using Microsoft.Ajax.Utilities;
using Microsoft.Practices.Unity;
using NHibernate;

namespace MBCORPWEB.Controllers
{
    public class UnityControllerFactory:IControllerFactory
    {

        private UnityContainer _container;


        public UnityControllerFactory()
        {
            _container = new UnityContainer();
            
            var session = ConfiguracaoNHibernate.NHibernateSessionFactory.Criar().OpenSession();

            _container.RegisterInstance<ISession>(session);
            _container.RegisterType(typeof(IMedicos), typeof(Medicos));
            _container.RegisterType(typeof (IController), typeof (MedicoController), "Medico");            
            _container.RegisterType(typeof(IController), typeof(AccountController), "Account");
            _container.RegisterType(typeof (IController), typeof (HomeController), "Home");
            _container.RegisterType(typeof(IController), typeof(HomeController), "__browserLink");
        }

        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            return _container.Resolve<IController>(controllerName);           
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return System.Web.SessionState.SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            _container.Teardown(controller);
        }
    }
}