using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoDeDadosJBS
{
    interface IIntegradorViaFacil
    {
        string EnviarRequisicaoViaFacil(string xml);
    }
}
