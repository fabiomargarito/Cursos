using System;
using System.Collections.Generic;
using NHibernate;

namespace MBCorpHealth.Dominio.Contratos.Repositorio
{
    public interface IRepositorio<T>:IDisposable
    {
        bool Gravar(T entidade);
        IList<T> retornarPorCPF(string CPF);
        List<T> RetornarTodos();
        
    }
}