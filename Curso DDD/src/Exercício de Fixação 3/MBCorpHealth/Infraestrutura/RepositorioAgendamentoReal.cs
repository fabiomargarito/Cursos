using System.Collections.Generic;
using FluentNHibernate.Utils;
using MBCorpHealth.Dominio;
using MBCorpHealth.Infraestrutura;
using NHibernate;
using System.Linq;

namespace MBCorpHealth.Aplicacao
{
    public class RepositorioAgendamento:IRepositorioAgendamento
    {
        private readonly ISession _session;

        public RepositorioAgendamento(ISession session)
        {
            _session = session;
        }

        public bool GravarMedico(Medico medico)
        {
            using (ISession session = _session)
            {
                session.SaveOrUpdate(medico);
                session.Flush();
            }

            return true;
        }

        public List<Medico> ListarMedicos()
        {
            using (ISession session = _session)
            {
                return session.QueryOver<Medico>().List().ToList();
            }
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