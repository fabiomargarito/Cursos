using System.Collections.Generic;

namespace MBCorpHealth.Dominio
{
    public class PlanoDeSaude
    {
        public PlanoDeSaude()
        {
        }


        public PlanoDeSaude(string cnpj, string nomePlano, string tipoDoPlano)
        {
            CNPJ = cnpj;
            NomePlano = nomePlano;
            TipoDoPlano = tipoDoPlano;
        }

        public virtual string CNPJ { get; protected set; }
        public virtual string NomePlano { get; protected set; }
        public virtual string TipoDoPlano { get; protected set; }

        public virtual bool VerificarCobertura(Exame exame)
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