using System.Collections.Generic;
using System.Linq;
using MBCorpHealthTest.Dominio.Entidades;
using MBCorpHealthTest.GUI.ViewModels;
using MBCorpHealthTestTests;
using NHibernate;

namespace MBCorpHealthTest.Aplicacao.Servicos
{
    public class ServicoCRUDMedico
    {
        private readonly ISession _session;
        private readonly IMedicos _repositorioDeMedicos;

        public ServicoCRUDMedico(ISession _session, IMedicos repositorioDeMedicos)
        {
            this._session = _session;
            _repositorioDeMedicos = repositorioDeMedicos;
        }

        public IList<MedicoViewModel> ConsultaMedicoPorTrechoDoNome(string trechoDoNome)
        {


            IList<Medico> listagemDeMedicos = _repositorioDeMedicos.ConsultarPorTrechoDoNome(trechoDoNome);

            return listagemDeMedicos.Select(med => new MedicoViewModel {CRM = med.CRM, Nome = med.Nome}).ToList();
        }
    }
}
