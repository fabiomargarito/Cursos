using System;

namespace MBCorpHealth.Dominio
{
    public class Paciente:Pessoa
    {
        public Paciente(string nome, string cpf) : base(nome, cpf)
        {
        }

        public  PlanoDeSaude PlanoDeSaude { get; private set; }
        public string Email { get; private set; }
        public Telefone Telefone { get; set; }

        public void DefinirPlanoDeSaude(PlanoDeSaude planoDeSaude)
        {
          ValidarPlanoDeSaude(planoDeSaude);
            PlanoDeSaude = planoDeSaude;
        }

        private void ValidarPlanoDeSaude(PlanoDeSaude planoDeSaude)
        {
            if (planoDeSaude == null) throw new ArgumentNullException("É necessário informar o plano de saúde!");

        }



    }

    public class Telefone
    {
        public string DDD { get; set; }
        public string Numero { get; set; }
    }
}