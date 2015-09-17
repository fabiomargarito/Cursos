using System;
using System.Security.Principal;

namespace JBSMedical
{
    public class Paciente
    {
        public Paciente(string cpf, string nome)
        {
            ValidarEntrada(cpf,nome);

            CPF = cpf;
            Nome = nome;            
        }

        private void ValidarEntrada(string cpf, string nome)
        {
            if (string.IsNullOrWhiteSpace(cpf)) throw new ArgumentNullException(nameof(cpf));
            if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentNullException(nameof(nome));
        }

        public string CPF { get; protected set; }
        public string Nome { get; protected set; }
        
        public Municipio Municipio { get; protected set; }

        public PlanoDeSaude PlanoDeSaude { get; protected set; }
      

        public void InformarPlanoDeSaude(PlanoDeSaude planoDeSaude)
        {
            PlanoDeSaude = planoDeSaude;
        }
    }

    public class Municipio
    {
        private readonly string _nome;

        private Municipio(string Nome)
        {
            _nome = Nome;
        }
    }
}