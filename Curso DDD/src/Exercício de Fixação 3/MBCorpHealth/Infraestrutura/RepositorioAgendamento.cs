using System.Collections.Generic;
using MBCorpHealth.Dominio;

namespace MBCorpHealth.Aplicacao
{
    public class RepositorioAgendamentoFake:IRepositorioAgendamento
    {
        public bool GravarMedico(Medico medico)
        {
            return true;
        }

        public List<Medico> ListarMedicos()
        {
            List<Medico> medicos = new List<Medico>();
            medicos.Add(new Medico("fabio","sdf","123"));
            medicos.Add(new Medico("fabio 2", "sdf", "1234"));

            return medicos;
        }


        public List<Medico> ListarMedicosPorNome(string nome)
        {
            List<Medico> medicos = new List<Medico>();
            medicos.Add(new Medico("fabio", "sdf", "123"));
            medicos.Add(new Medico("fabio 2", "sdf", "1234"));

            return medicos;
        }

        public bool GravarPaciente(Paciente paciente)
        {
            throw new System.NotImplementedException();
        }

        public List<Paciente> ListarPacientes()
        {
            throw new System.NotImplementedException();
        }

        public List<Paciente> ListarPacientesPorNome(string nome)
        {
            throw new System.NotImplementedException();
        }
    }
}