using JBSMedical.CadastrosBoundedContext.Apresentacao.DTOS;
using JBSMedical.CadastrosBoundedContext.Dominio.Contratos.Repositorios;
using JBSMedical.CadastrosBoundedContext.Dominio.Entidades;

namespace JBSMedical.CadastrosBoundedContext.Aplicacacao.Servicos
{
    public class ServicoDeGravacaoDePaciente
    {
        private readonly IPacientes _pacientes;

        public ServicoDeGravacaoDePaciente(IPacientes pacientes)
        {
            _pacientes = pacientes;
        }

        public bool GravarPaciente(DTOPaciente paciente)
        {            
            return _pacientes.Gravar(new Paciente(paciente.Cpf,paciente.Nome));
        }

        public Paciente ConsultarDadosDoPaciente(string s)
        {
            
            return _pacientes.RetornarPorCPF(s);
        }
    }
    
}