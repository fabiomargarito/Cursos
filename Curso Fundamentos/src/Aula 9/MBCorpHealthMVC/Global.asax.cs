using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MBCorpHealth.Infraestrutura.Repositorio;
using NHibernate;

namespace MBCorpHealthMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            ISession session = ConfiguracaoNHibernate.Criar().OpenSession();
            HttpContext.Current.Items.Add("session", session);
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
           var session = (ISession)HttpContext.Current.Items["session"];
            session.Dispose();
        }

    }
}
