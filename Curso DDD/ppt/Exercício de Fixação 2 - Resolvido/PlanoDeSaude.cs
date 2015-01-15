using System.Collections.Generic;

namespace MBCorpHealth.Dominio
{
    public class PlanoDeSaude
    {
        public string CNPJ { get; private set; }
        public string NomePlano { get; private set; }
        public string TipoDoPlano { get; private set; }        
    }
}