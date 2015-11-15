using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DALVeiculo;
using System.Net;
using System.IO;

namespace ServicoDeDadosJBS
{
    public class DadosVeiculo : IDadosVeiculo
    {
        public void Correr()
        {

        }

        public bool inserirVeiculo(Veiculo veiculo)
        {
            DALVeiculo.DALVeiculo dalVeiculo = new DALVeiculo.DALVeiculo();
            return dalVeiculo.inserirVeiculo(veiculo);

        }

        public List<Veiculo> retornarVeiculos()
        {
            DALVeiculo.DALVeiculo dalVeiculo = new DALVeiculo.DALVeiculo();
            var veiculos = dalVeiculo.retornarVeiculos();
            return veiculos;
        }
    }  
}
