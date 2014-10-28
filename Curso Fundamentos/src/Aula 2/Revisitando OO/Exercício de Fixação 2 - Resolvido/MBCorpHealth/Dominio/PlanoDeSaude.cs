using System.Collections.Generic;

namespace MBCorpHealth.Dominio
{
    public class PlanoDeSaude
    {
        public string CNPJ { get; private set; }
        public string NomePlano { get; private set; }
        public ISet<Cobertura> Coberturas { get; private set; }

        public bool VerificarCobertura(Exame exame)
        {
            //Verifica Cobertura
            return true;
        }
    }
}