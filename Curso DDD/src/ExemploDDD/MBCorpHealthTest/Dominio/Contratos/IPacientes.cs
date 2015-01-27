using System.Collections.Generic;
using MBCorpHealthTest.Dominio.Entidades;

namespace MBCorpHealthTest.Dominio.Contratos
{
    public   interface IPacientes
    {
        IList<Paciente> PesquisarPacientePorTrechoDoNome(string nome);
        Paciente pesquisarPacientePorCPF(string cpf);
        bool Gravar(Paciente paciente);

    }
}