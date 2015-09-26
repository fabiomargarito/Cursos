using JBSMedical.CadastrosBoundedContext.Dominio.Entidades;

namespace JBSMedical.CadastrosBoundedContext.Dominio.Contratos.Repositorios
{
    public interface IPacientes
    {
         bool Gravar(Paciente paciente);

         Paciente RetornarPorCPF(string s);
    }
}