using System;
using System.ComponentModel.DataAnnotations;

namespace MBCorpHealthTest.ViewModel
{
    public class MedicoViewModel
    {
        [Required]
        public string CRM { get;  set; }        
        public string Nome { get; set; }
        [Required]
        public string Estado { get; set; }


    }
}