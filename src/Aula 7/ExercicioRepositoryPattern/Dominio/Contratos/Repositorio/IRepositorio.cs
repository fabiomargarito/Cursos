using System.Collections.Generic;

namespace MBCorpHealth.Dominio.Contratos.Repositorio
{
    public interface IRepositorio<T>
    {
        bool Gravar(T entidade);
        IList<T> retornarPorCPF(string CPF);             
    }
}