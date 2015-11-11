using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using JBSDAL;
using System.Collections.Generic;

namespace TestesIntegrados
{
    [TestClass]
    public class TestesIntegrados
    {
        [TestMethod]
        public void RetornarTodosOsVeiculos()
        {
            IList<VeiculoDTO> veiculos;

            DALVEICULOS dalVeiculos = new DALVEICULOS();
            veiculos = dalVeiculos.RetornarListaDeVeiculos();


            Assert.IsTrue(veiculos.Count > 0);
        }

        [TestMethod]
        public void InserirVeiculo() {

            VeiculoDTO veiculo = new VeiculoDTO { Placa = "EMY6514", Categoria = 1 };

            DALVEICULOS dalveiculos = new DALVEICULOS();

            var retorno = dalveiculos.InserirVeiculo(veiculo);

            Assert.IsTrue(retorno);
        }

        [TestMethod]
        public void RetornarTodosOsVeiculosAtravesDeServico()
        {
            ServicoDeDadosJBS.ServicoDeDadosJBSClient servico = new ServicoDeDadosJBS.ServicoDeDadosJBSClient();
            IList<VeiculoDTO> retorno = servico.RetornarListaDeVeiculos();
            Assert.IsTrue(retorno.Count > 0);
        }

        [TestMethod]
        public void InserirVeiculoAtravesDeServico() {
            ServicoDeDadosJBS.ServicoDeDadosJBSClient servico = new ServicoDeDadosJBS.ServicoDeDadosJBSClient();

            VeiculoDTO veiculo = new VeiculoDTO { Placa = "EMZ3423", Categoria = 1 };

            var retorno = servico.InserirVeiculo(veiculo);

            Assert.IsTrue(retorno);
        }

        }
}
