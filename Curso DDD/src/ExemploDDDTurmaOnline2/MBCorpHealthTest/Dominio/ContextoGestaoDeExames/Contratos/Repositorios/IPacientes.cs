using System.Collections.Generic;
using MBCorpHealthTest.Dominio.Entidades;

namespace MBCorpHealthTest.Dominio.Contratos.Repositorios
{
    public interface IPacientes
    {
        IList<Paciente> ConsultarPacientesPorTrechoDoNome(string trechoDoNome);
        Paciente ConsultarPacientesPorCPF(string CPF);
    }
}