using System;
using System.Collections.Generic;

namespace MBCorpHealthTest.Infraestrutura.ContextoBooking
{
    public class ServicoDeBookingFake : IServicoDeBooking
    {
        public IEnumerable<DateTime> Verificar(string CBHPM, int codigoCentroDeDiagnostico)
        {
            IList<DateTime> agenda = new List<DateTime>();
            agenda.Add(DateTime.Now);
            agenda.Add(DateTime.Now.AddDays(12));
            agenda.Add(DateTime.Now.AddDays(22));
            return agenda;
        }
    }
}