using System.Collections.Generic;
using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Entidades;

namespace MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Contratos
{
    public interface IPacientes
    {
        IList<Paciente> PesquisarPacientePorTrechoDoNome(string nome);
        Paciente pesquisarPacientePorCPF(string cpf);
        bool Gravar(Paciente paciente);

    }
}