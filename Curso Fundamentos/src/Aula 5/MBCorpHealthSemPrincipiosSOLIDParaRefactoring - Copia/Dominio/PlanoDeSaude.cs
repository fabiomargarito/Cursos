using System.Collections.Generic;

namespace MBCorpHealth.Dominio
{
    public class PlanoDeSaude
    {
        public PlanoDeSaude(string cnpj, string nomePlano, string tipoDoPlano)
        {
            CNPJ = cnpj;
            NomePlano = nomePlano;
            TipoDoPlano = tipoDoPlano;
        }

        public string CNPJ { get; private set; }
        public string NomePlano { get; private set; }
        public string TipoDoPlano { get; private set; }

        public bool VerificarCobertura(Exame exame)
        {

            switch (CNPJ)
            {
                //CNPJ Porto Seguro Saúde
                case "001.001.0001/00001-10" :      return (new CoberturaPlanoSaudePortoSeguro()).VerificarCobertura(exame);

                //CNPJ Bradesco
                case "002.002.0002/00002-20": return (new CoberturaPlanoSaudeBradesco()).VerificarCobertura(exame);

                //CNPJ Amil
                case "003.003.0003/00003-30":return (new CoberturaPlanoSaudeAmil()).VerificarCobertura(exame);

                default:return false;
            }                       
            
        }

        
    }

    public interface ICoberturaPlanoSaude
    {
        bool VerificarCobertura(Exame exame);
    
    }


    public class CoberturaPlanoSaudePortoSeguro:ICoberturaPlanoSaude
    {
        public bool VerificarCobertura(Exame exame)
        {
            //consulta web service da porto
            return true;
        }
    }


    public class CoberturaPlanoSaudeBradesco : ICoberturaPlanoSaude
    {
        public bool VerificarCobertura(Exame exame)
        {
            //consulta web service da porto
            return false;
        }
    }

    public class CoberturaPlanoSaudeAmil : ICoberturaPlanoSaude
    {
        public bool VerificarCobertura(Exame exame)
        {
            //consulta web service da porto
            return true;
        }
    }

}