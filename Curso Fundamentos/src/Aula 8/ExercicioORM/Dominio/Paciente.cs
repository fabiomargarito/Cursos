using System;

namespace MBCorpHealth.Dominio
{
    public class Paciente:Pessoa
    {
        public Paciente()
        {
        }

        public  Paciente(string nome, string cpf) : base(nome, cpf)
        {
        }

        public virtual  PlanoDeSaude PlanoDeSaude { get; protected set; }

        public virtual void DefinirPlanoDeSaude(PlanoDeSaude planoDeSaude)
        {
          ValidarPlanoDeSaude(planoDeSaude);
            PlanoDeSaude = planoDeSaude;
        }

        private void ValidarPlanoDeSaude(PlanoDeSaude planoDeSaude)
        {
            if (planoDeSaude == null) throw new ArgumentNullException("É necessário informar o plano de saúde!");

        }
    }
}