using System.Collections.Generic;

namespace ExemploDeCriacaoDeUmRepositorioTurma4
{
    public interface IRepositorioAtendente
    {
        bool Excluir(Atendente atendente);
        bool Gravar(Atendente atendente);
        Atendente retornarPorCPF(string cpf);
        IList<Atendente> retornarTodos();
    }
}