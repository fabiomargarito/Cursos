using System;
using System.Collections.Generic;
using System.Linq;

namespace MBCorpHealth.Dominio
{

    public abstract class PlanoDeSaudeBase
    {
         public virtual string CNPJ { get;  set; }
         public virtual string NomePlano { get;  set; }
         public virtual string TipoDoPlano { get;  set; }

        public abstract  bool VerificarCobertura(Exame exame);

    }

    public class PlanoDeSaudePortoSeguro:PlanoDeSaudeBase
    {
        public override string CNPJ { get; set; }
        public override string NomePlano { get;  set; }
        public override string TipoDoPlano { get;  set; }

        public override bool VerificarCobertura(Exame exame)
        {        
                //consulta web service da porto
                return true;
        }           
    }

    public class PlanoDeSaudeBradesco : PlanoDeSaudeBase
    {
        public override string CNPJ { get; set; }
        public override string NomePlano { get;  set; }
        public override string TipoDoPlano { get;  set; }

        public override bool VerificarCobertura(Exame exame)
        {
            //consulta web service do Bradesco
            return false;
        }
    }


    public class PlanoDeSaudeAmil : PlanoDeSaudeBase
    {
        public override string CNPJ { get; set; }
        public override string NomePlano { get;  set; }
        public override string TipoDoPlano { get;  set; }

        public override bool VerificarCobertura(Exame exame)
        {
            //consulta web service da Amil
            return true;
        }
    }

    public class PlanoDeSaudeSulAmerica : PlanoDeSaudeBase
    {
        public override string CNPJ { get; set; }
        public override string NomePlano { get;  set; }
        public override string TipoDoPlano { get;  set; }

        public override bool VerificarCobertura(Exame exame)
        {
            //consulta web service da SulAmerica
            return true;
        }
    }

    public class PlanoDePreventSenior : PlanoDeSaudeBase
    {
        public override string CNPJ { get; set; }
        public override string NomePlano { get;  set; }
        public override string TipoDoPlano { get;  set; }

        public override bool VerificarCobertura(Exame exame)
        {
            //consulta web service da prevent senior
            return true;
        }
    }


    public class FabricaDePlanos
    {
        public List<PlanoDeSaudeBase> PlanosDeSaude { get; set; }

        public FabricaDePlanos(List<PlanoDeSaudeBase> planosDeSaude)
        {
            PlanosDeSaude = planosDeSaude;
        }

       
        public PlanoDeSaudeBase RetornarPlanoPorCNPJ(string cnpj)
        {
            return PlanosDeSaude.FirstOrDefault(campo=>campo.CNPJ == cnpj);
        }
    }

}







     ////CNPJ Bradesco Saúde
     //       if (CNPJ == "002.002.0002/00002-20")
     //       {
     //           return false;
     //       }

     //       //CNPJ Amil
     //       if (CNPJ == "003.003.0003/00003-30")
     //       {
     //           return true;
     //       }

     //       //CNPJ Sul América
     //       if (CNPJ == "005.005.0005/00005-30")
     //       {
     //           //Busca serviço web da Sul América
     //           return true;
     //       }

     //       return false;
     //   }