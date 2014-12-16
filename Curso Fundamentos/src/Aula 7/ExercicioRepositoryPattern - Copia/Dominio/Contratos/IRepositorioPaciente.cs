using System.Collections.Generic;

namespace MBCorpHealth.Dominio.Contratos
{
    public interface IRepositorioPaciente
    {
        bool Gravar(Paciente paciente);
        List<Paciente> RetornarPorTrechoNome(string fa);
        bool Excluir(Paciente paciente);
    }
}