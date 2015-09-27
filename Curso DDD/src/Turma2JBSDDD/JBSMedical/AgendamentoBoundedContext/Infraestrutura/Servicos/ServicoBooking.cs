using System;
using System.Collections.Generic;
using JBSMedical.AgendamentoBoundedContext.Infraestrutura.Contratos;

namespace JBSMedical.AgendamentoBoundedContext.Infraestrutura.Servicos
{
    public class ServicoBooking : IServicoBooking
    {
        public IList<DateTime> ConsultarDisponibilidade(string codigoTipoExame, string codigoCentroDiagnostico)
        {
            List<DateTime> datas = new List<DateTime>();

            datas.Add(new DateTime(2015,09,25));
            datas.Add(new DateTime(2015, 09, 26));

            return datas;
        }
    }
}