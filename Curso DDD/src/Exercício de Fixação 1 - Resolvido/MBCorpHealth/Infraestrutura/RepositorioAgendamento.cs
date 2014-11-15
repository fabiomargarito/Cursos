using System.Collections.Generic;
using MBCorpHealth.Dominio;

namespace MBCorpHealth.Aplicacao
{
    public class RepositorioAgendamento
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

    }
}