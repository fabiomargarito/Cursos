using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace IntegradorSistemaPedagio.Core
{
    [ServiceContract]
    public interface IIntegradorSistemaPedagio
    {
        [OperationContract]
        string EnviarRequisicaoSOAP(string mensagemSOAP);

        [OperationContract]        
        string EnviarRequisicaoPostHttp(string enderecoHTTP,string parametrosPost);
        
    }

}
