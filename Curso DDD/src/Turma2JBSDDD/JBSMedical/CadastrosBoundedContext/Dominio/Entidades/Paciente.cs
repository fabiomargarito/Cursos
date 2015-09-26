using System;

namespace JBSMedical.CadastrosBoundedContext.Dominio.Entidades
{
    public class Paciente
    {
        public Paciente(string cpf, string nome)
        {
            ValidarEntrada(cpf,nome);

            CPF = cpf;
            Nome = nome;            
        }

        public Paciente()
        {
        }

        private void ValidarEntrada(string cpf, string nome)
        {
            if (string.IsNullOrWhiteSpace(cpf)) throw new ArgumentNullException(nameof(cpf));
            if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentNullException(nameof(nome));
        }

        public string CPF { get; protected set; }
        public string Nome { get; protected set; }
        

        public PlanoDeSaude PlanoDeSaude { get; protected set; }
      

        public void InformarPlanoDeSaude(PlanoDeSaude planoDeSaude)
        {
            PlanoDeSaude = planoDeSaude;
        }
    }

  
}