using System.Collections.Generic;
using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Contratos;
using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Entidades;

namespace MBCorpHealthTest.Infraestrutura.ContextoAdministracaoDeAgendamentosDeExame.Repositorios
{
    public class Pacientes:IPacientes
    {
        public IList<Paciente> PesquisarPacientePorTrechoDoNome(string nome)
        {
            IList<Paciente> pacientes = new List<Paciente>();
            pacientes.Add( new Paciente("123","Fabio","fabiomargarito@gmail.com"));
            return pacientes;
        }
        public Paciente pesquisarPacientePorCPF(string cpf)
        {
            return new Paciente("123", "Fabio", "fabiomargarito@gmail.com");
        }
        public bool Gravar(Paciente paciente)
        {
            return true;
        }
    }
}