using System.Web.Mvc;
using MBCorpHealth.Aplicacao.Servico;
using MBCorpHealth.Dominio.Contratos;
using MBCorpHealth.Infraestrutura.Repositorio;
using MBCorpHealth.View.ViewModel;
using Microsoft.Practices.Unity;
using NHibernate;

namespace MBCorpHealthWEB.Controllers
{
    public class PacienteController : Controller
    {
        private UnityContainer _unityContainer;
        // GET: Paciente        
        public PacienteController()
        {
            _unityContainer = new UnityContainer();
            _unityContainer.RegisterType<IRepositorioPaciente, RepositorioPaciente>();
            _unityContainer.RegisterInstance<ISession>(ConfiguracaoNHibernate.Criar().OpenSession());
        }

        public ActionResult Index()
        {

            ServicoDePaciente servicoDePaciente = _unityContainer.Resolve<ServicoDePaciente>();

            var listaDePacientes = servicoDePaciente.ListarPorTrecho("");
            
            return View(listaDePacientes);
        }


        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Criar(PacienteViewModel pacienteViewModel)
        {      
            ServicoDePaciente servicoDePaciente = _unityContainer.Resolve<ServicoDePaciente>();

            servicoDePaciente.Gravar(pacienteViewModel);

            return RedirectToAction("Index");
            
        }

        public ActionResult Excluir(string cpf)
        {
            ServicoDePaciente servicoDePaciente = _unityContainer.Resolve<ServicoDePaciente>();

            servicoDePaciente.Excluir(new PacienteViewModel {Cpf = cpf,Nome = "  "});
            return RedirectToAction("Index");
        }
    }
}
