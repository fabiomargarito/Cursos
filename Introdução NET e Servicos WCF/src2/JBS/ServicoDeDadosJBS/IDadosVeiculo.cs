using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicoDeDadosJBS
{    
    [ServiceContract]
    public interface IDadosVeiculo
    {
        [OperationContract]
        List<DALVeiculo.Veiculo> retornarVeiculos();

        [OperationContract]
        void Correr();

        [OperationContract]
        bool inserirVeiculo(DALVeiculo.Veiculo veiculo);
    }
}    

