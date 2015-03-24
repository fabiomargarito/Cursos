using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MBCorpHealthTest.Aplicacao.Servicos;
using MBCorpHealthTest.GUI.ViewModels;
using MBCorpHealthTest.Infraestrutura.Repositorios;
using MBCorpHealthTestTests;
using NHibernate;

namespace MBCorpHeatlhTestRestAPI.Controllers
{
    public class ValuesController : ApiController
    {

        
        public IList<MedicoViewModel> ConsultaMedicoPorTrechoDoNome(string trechoDoNome)
        {
            IMedicos medicos = new MedicosFake();
            
            ISession session = ConfiguracaoNHibernate.NHibernateSessionFactory.Criar().OpenSession();

            return (new ServicoCRUDMedico(session,medicos)).ConsultaMedicoPorTrechoDoNome(trechoDoNome);
        }


        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
