using System.Collections.Generic;
using MBCorpHealthTest.Dominio.Entidades;

namespace MBCorpHealthTestTests
{
    public interface IMedicos
    {
        Medico ConsultarPorCRM(string CRM);
        IList<Medico> ConsultarPorTrechoDoNome(string Nome);
    }
}