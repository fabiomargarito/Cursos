using JBSMedical.CadastrosBoundedContext.Dominio.Contratos.Repositorios;
using JBSMedical.CadastrosBoundedContext.Dominio.Entidades;

namespace JBSMedical.CadastrosBoundedContext.Infraestrutura.Repositorios
{
    public class Pacientes:IPacientes
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