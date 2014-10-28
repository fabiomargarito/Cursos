using System.Collections.Generic;

namespace MBCorpHealth.Dominio
{
    public class PlanoDeSaude
    {
        public string CNPJ { get; private set; }
        public string NomePlano { get; private set; }
        public string TipoDoPlano { get; private set; }

        public bool VerificarCobertura(Exame exame)
        {
            //CNPJ Porto Seguro Saúde
            if (CNPJ == "001.001.0001/00001-10")
            {
                //consulta web service da porto
                return true;
            }
            //CNPJ Bradesco Saúde
            if (CNPJ == "002.002.0002/00002-20")
            {
                return false;
            }

            //CNPJ Amil
            if (CNPJ == "003.003.0003/00003-30")
            {
                return true;
            }
            return false;
        }
    }
}