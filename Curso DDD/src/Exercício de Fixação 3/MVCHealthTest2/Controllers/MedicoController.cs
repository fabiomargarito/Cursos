using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MBCorpHealth.Aplicacao;
using MBCorpHealth.Dominio;
using MBCorpHealth.Infraestrutura;
using Microsoft.Practices.Unity;
using NHibernate;

namespace MVCHealthTest2.Controllers
{
    public class MedicoController : Controller
    {
        // GET: Medico
        public ActionResult Index()
        {
            var container = new UnityContainer();

            container.RegisterInstance<ISession>(ConfiguracaoNHibernate.Criar().OpenSession());
            container.RegisterType<IRepositorioAgendamento, RepositorioAgendamento>();

            MedicoServicoDePersistencia medicoServicoDePersistencia = container.Resolve<MedicoServicoDePersistencia>();
            List<MedicoViewModel> medicos = medicoServicoDePersistencia.ListarMedicos();

            return View(medicos);
        }

        [HttpGet]
        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Criar(MedicoViewModel medico)
        {
            var container = new UnityContainer();
            container.RegisterType<IRepositorioAgendamento, RepositorioAgendamentoFake>();

            MedicoServicoDePersistencia medicoServicoDePersistencia = container.Resolve<MedicoServicoDePersistencia>();

            
            medicoServicoDePersistencia.Gravar(medico);

            return View("Sucesso");
        }
    }
}