using System.Web.Mvc;
using MBCorpHealthTest.Aplicacao.Servicos;
using MBCorpHealthTest.Dominio.Entidades;
using MBCorpHealthTest.GUI.ViewModels;
using MBCorpHealthTest.Infraestrutura.Repositorios;
using MBCorpHealthTestTests;
using NHibernate;

namespace MBCORPWEB.Controllers
{
    public class MedicoController : Controller
    {
        private ISession _session;
        private readonly IMedicos _medicos;
        // GET: Medico
        public MedicoController(ISession session,IMedicos medicos)
        {
            _session = session;
            _medicos = medicos;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pesquisar(MedicoViewModel medico)
        {
            var servicoCrudMedico = new ServicoCRUDMedico(_session, _medicos);
            return View(servicoCrudMedico.ConsultaMedicoPorTrechoDoNome(medico.Nome));
        }
    }
}