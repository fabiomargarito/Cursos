using MBCorpHealthTest.Dominio.Entidades;

namespace MBCorpHealthTest.Infraestrutura.Repositorios
{
    public class Repositorio
    {

        internal Paciente ObterPacientePeloCPF(string cpfPaciente)
        {

            return new Paciente(cpfPaciente,"teste","teste");

        }

        internal Medico ObterMedicoPeloCrm(string crmMedico)
        {

            return new Medico(crmMedico, "teste", "SP");

        }

        internal Atendente ObterAtendentePeloCPF(string cfpAtendente)
        {

            return new Atendente(cfpAtendente, "teste");

        }

    }
}