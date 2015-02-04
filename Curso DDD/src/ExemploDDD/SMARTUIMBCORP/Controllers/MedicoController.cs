using System.Web.Mvc;
using MBCorpHealthTest.Aplicacao;
using MBCorpHealthTest.Dominio.Contratos;
using MBCorpHealthTest.ViewModel;
using NHibernate;

namespace SMARTUIMBCORP.Controllers
{
    public class MedicoController : Controller
    {
        private readonly IMedicos _medicos;

        public MedicoController(ISession session,IMedicos medicos)
        {
            _medicos = medicos;
            this.session = session;
        }

        private ISession session { get; set; }
        

        // GET: Medico
        public ActionResult Index()
        {
            return View();
        }

        // GET: Medico/Details/5
        public ActionResult Pesquisar(MedicoViewModel medicoViewModel)
        {
         
                ServicoDePersistenciaDeMedico servicoDePersistenciaDeMedico = new ServicoDePersistenciaDeMedico();
                var medico = servicoDePersistenciaDeMedico.PesquisarMedicoPorCRMEEstado(medicoViewModel, session, _medicos);

                return View(medico);
           
        }

        // GET: Medico/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Medico/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Medico/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Medico/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Medico/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Medico/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
