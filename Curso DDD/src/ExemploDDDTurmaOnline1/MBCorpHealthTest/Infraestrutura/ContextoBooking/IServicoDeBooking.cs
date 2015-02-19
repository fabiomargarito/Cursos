using System;
using System.Collections.Generic;

namespace MBCorpHealthTest.Infraestrutura.ContextoBooking
{
    public interface IServicoDeBooking
    {
        IEnumerable<DateTime> Verificar(string CBHPM, int codigoCentroDeDiagnostico);
    }
}