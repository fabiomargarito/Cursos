using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MBCorpHealth.Infraestrutura;
using MVCHealthTest2.Controllers;

namespace MVCHealthTest2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Sessao.SessaoNHibernate =  ConfiguracaoNHibernate.Criar().OpenSession();
            
        }


        protected void Application_end()
        {

        }

    }
}
