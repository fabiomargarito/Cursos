using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBSHealthCare.Dominio.Entidade;
using NHibernate.Mapping;

namespace JBSHealthCare.View.ViewModels
{
    public class AgendamentoViewModel
    {
        public string cpf { get; set; }
        public string crm { get; set; }
        public string numeroCID { get; set; }
    }
}
