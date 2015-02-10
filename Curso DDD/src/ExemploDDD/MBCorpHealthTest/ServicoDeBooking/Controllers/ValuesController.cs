using System;
using System.Collections.Generic;
using System.Web.Http;
using MBCorpHealthTest.Infraestrutura.ContextoBooking;

namespace ServicoDeBooking.Controllers
{
    public class ServicoBookingController : ApiController
    {
        [HttpGet]
        public IEnumerable<DateTime> Verificar(string CBHPM, int codigoCentroDeDiagnostico)
        {
            IServicoDeBooking servicoDeBooking = new ServicoDeBookingFake();
            return servicoDeBooking.Verificar(CBHPM, codigoCentroDeDiagnostico);
        }
    }
}
