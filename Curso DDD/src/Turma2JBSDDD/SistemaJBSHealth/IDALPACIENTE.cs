using JBSMedical;

namespace SistemaJBSHealth
{
    public interface IDALPACIENTE
    {
         bool Gravar(Paciente paciente);

         Paciente RetornarPorCPF(string s);
    }
}