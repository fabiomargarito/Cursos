using System;
using System.Collections.Generic;

namespace JBSMedical.AgendamentoBoundedContext.Infraestrutura.Contratos
{
    public interface IServicoBooking
    {
        IList<DateTime> ConsultarDisponibilidade(string s, string s1);
    }
}