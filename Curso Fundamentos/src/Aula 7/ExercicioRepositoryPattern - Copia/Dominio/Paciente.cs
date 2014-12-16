using System;

namespace MBCorpHealth.Dominio
{
    public class Paciente:Pessoa
    {
        public  Paciente(string nome, string cpf) : base(nome, cpf)
        {
        }


        public Paciente()
        {
        }

        public virtual  PlanoDeSaude PlDeSaude { get; protected set; }

        public virtual void DefinirPlanoDeSaude(PlanoDeSaude planoDeSaude)
        {
          ValidarPlanoDeSaude(planoDeSaude);
            PlDeSaude = planoDeSaude;
        }

        protected  virtual void ValidarPlanoDeSaude(PlanoDeSaude planoDeSaude)
        {
            if (planoDeSaude == null) throw new ArgumentNullException("É necessário informar o plano de saúde!");

        }
    }
}