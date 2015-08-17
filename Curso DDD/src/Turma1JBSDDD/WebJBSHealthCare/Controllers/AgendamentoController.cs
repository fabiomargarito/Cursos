using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JBSHealthCare.Aplicacao.Servico;
using JBSHealthCare.Dominio.Entidade;
using JBSHealthCare.Infraestrutura.Repositorio;
using JBSHealthCare.View.ViewModels;

namespace WebJBSHealthCare.Controllers
{
    public class AgendamentoController : Controller
    {
        // GET: Agendamento
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Criar(AgendamentoViewModel agendamentoViewModel)
        {
            ServicoDeAgendamento servicoDeAgendamento = new ServicoDeAgendamento(new Agendamentos());
            servicoDeAgendamento.CriarAgendamento(agendamentoViewModel);
            return View("CriarOK");
        }

    }
}
