using JBSMedical.Dominio.Contratos.Repositorios;
using JBSMedical.Dominio.Entidades;

namespace JBSMedical.Infraestrutura.Repositorios
{
    public class DalPacienteFake:IPacientes
    {
        public bool Gravar(Paciente paciente)
        {
            return true;
        }

        public Paciente RetornarPorCPF(string s)
        {
            Paciente paciente = new Paciente("12345", "Fabio Margarito");
            paciente.InformarPlanoDeSaude(new PlanoDeSaude { CNPJ = "456", RazaoSocial = "JBS Medical Services" });
            return paciente;
        }
    }
}