using JBSMedical.Dominio.Entidades;

namespace JBSMedical.Dominio.Contratos.Repositorios
{
    public interface IPacientes
    {
         bool Gravar(Paciente paciente);

         Paciente RetornarPorCPF(string s);
    }
}