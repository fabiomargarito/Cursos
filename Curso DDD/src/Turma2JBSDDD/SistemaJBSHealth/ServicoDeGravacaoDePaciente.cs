using JBSMedical;

namespace SistemaJBSHealth
{
    public class ServicoDeGravacaoDePaciente
    {
        private readonly IDALPACIENTE _dalpaciente;

        public ServicoDeGravacaoDePaciente(IDALPACIENTE dalpaciente)
        {
            _dalpaciente = dalpaciente;
        }

        public bool GravarPaciente(Paciente paciente)
        {            
            return _dalpaciente.Gravar(paciente);
        }

        public Paciente ConsultarDadosDoPaciente(string s)
        {
            IDALPACIENTE dalpaciente = new DalPacienteFake();

            return dalpaciente.RetornarPorCPF(s);
        }
    }
}