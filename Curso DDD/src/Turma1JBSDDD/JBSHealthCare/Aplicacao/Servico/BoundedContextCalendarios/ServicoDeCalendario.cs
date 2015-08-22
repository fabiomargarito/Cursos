using System;
using System.Collections.Generic;

namespace JBSHealthCare.Aplicacao.Servico.BoundedContextCalendarios
{
    public class ServicoDeCalendario
    {
        public IList<DateTime> Consultar(int codigoCentroDiagnostico)
        {
            IList<DateTime> datas = new List<DateTime>();
            datas.Add(DateTime.Now);
            datas.Add(DateTime.Now.AddDays(12));

            return datas;
        }
    }
}