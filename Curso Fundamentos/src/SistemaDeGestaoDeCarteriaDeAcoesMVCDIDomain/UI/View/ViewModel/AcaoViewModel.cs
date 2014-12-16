using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace UI.View.ViewModel
{
    public class AcaoViewModel
    {        
        public string Codigo { get; set; }
        public EmpresaViewModel Empresa { get; set; }
        public IEnumerable<EmpresaViewModel> Empresas{ get; set; }
    }

}
