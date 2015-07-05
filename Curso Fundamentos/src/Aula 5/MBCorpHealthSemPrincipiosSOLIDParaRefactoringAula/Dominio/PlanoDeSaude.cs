using System.Collections.Generic;

namespace MBCorpHealth.Dominio
{
    public interface IValidacaoCoberturaPlanoDeSaude {
         bool VerificarCobertura(Exame exame);
    }

    public class ValidacaoCoberturaPlanoDeSaudePortoSeguro : IValidacaoCoberturaPlanoDeSaude
    {
        public bool VerificarCobertura(Exame exame) {
            //consulta web service da porto
            return true;
        }
    }

    public class ValidacaoCoberturaPlanoDeSaudePortoBradesco : IValidacaoCoberturaPlanoDeSaude
    {
        public bool VerificarCobertura(Exame exame)
        {
            //consulta web service da porto
            return false;
        }
    }

    public class ValidacaoCoberturaPlanoDeSaudeAmil : IValidacaoCoberturaPlanoDeSaude
    {
        public bool VerificarCobertura(Exame exame)
        {
            //consulta web service da porto
            return true;
        }
    }

    public class ValidacaoCoberturaPlanoDeSaudeSulAmerica : IValidacaoCoberturaPlanoDeSaude
    {
        public bool VerificarCobertura(Exame exame)
        {
            //consulta web service da porto
            return true;
        }
    }

    public class ValidacaoCoberturaPlanoDeSaudeFactory {
        public IValidacaoCoberturaPlanoDeSaude Criar(string CNPJ) {

            IValidacaoCoberturaPlanoDeSaude validacaoCoberturaPlanoDeSaude;

            //CNPJ Porto Seguro Saúde
            if (CNPJ == "001.001.0001/00001-10")
            {
                return validacaoCoberturaPlanoDeSaude = new ValidacaoCoberturaPlanoDeSaudePortoSeguro();                
            }
            //CNPJ Bradesco Saúde
            if (CNPJ == "002.002.0002/00002-20")
            {
                return validacaoCoberturaPlanoDeSaude = new ValidacaoCoberturaPlanoDeSaudePortoBradesco();                
            }

            //CNPJ Amil
            if (CNPJ == "003.003.0003/00003-30")
            {
                return validacaoCoberturaPlanoDeSaude = new ValidacaoCoberturaPlanoDeSaudeAmil();                
            }

            //CNPJ Sulamerica
            if (CNPJ == "004.004.0004/00004-40")
            {
                return validacaoCoberturaPlanoDeSaude = new ValidacaoCoberturaPlanoDeSaudeSulAmerica();                
            }

            throw new System.Exception("Não existe implementação para o CNPJ informado");

            
        }
    }

    public class PlanoDeSaude
    {
        public string CNPJ { get;  set; }
        public string NomePlano { get; private set; }
        public string TipoDoPlano { get; private set; }

        public bool VerificarCobertura(Exame exame)
        {
            IValidacaoCoberturaPlanoDeSaude validacaoCoberturaPlanoDeSaude = (new ValidacaoCoberturaPlanoDeSaudeFactory()).Criar(CNPJ);
            return validacaoCoberturaPlanoDeSaude.VerificarCobertura(exame);                      
        }
    }




}