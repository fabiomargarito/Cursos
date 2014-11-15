using System;

namespace MBCorpHealth.Dominio
{
    public class Paciente:Pessoa
    {
        public Paciente(string nome, string cpf) : base(nome, cpf)
        {
        }

        public  PlanoDeSaude PlanoDeSaude { get; private set; }

        public void DefinirPlanoDeSaude(PlanoDeSaude planoDeSaude)
        {
            PlanoDeSaude = planoDeSaude;
        }

        private void ValidarPlanoDeSaude(PlanoDeSaude planoDeSaude)
        {
            if (planoDeSaude == null) throw new ArgumentNullException("É necessário informar o plano de saúde!");

        }
    }
}