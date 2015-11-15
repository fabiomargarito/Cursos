using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DALVeiculo;
using System.Collections.Generic;
using System.Configuration;

namespace TesteJBS
{
    [TestClass]
    public class TestesJBS
    {
        [TestMethod]
        public void comoDesenvolvedorQueroTestarAConsultaDeVeiculos()
        {
            //Arrange
            DALVeiculo.DALVeiculo dalVeiculo = new DALVeiculo.DALVeiculo();            

            //Act
            List<Veiculo> veiculos = dalVeiculo.retornarVeiculos();

            //Assert

            Assert.IsTrue(veiculos.Count > 0);
        }


        [TestMethod]
        public void comoDesenvolvedorQueroTestarAInclusaoDeUmVeiculo() {

            //Arrange
            var  dalVeiculo = new DALVeiculo.DALVeiculo();            
            //Act
            var retorno = dalVeiculo.inserirVeiculo(new Veiculo { Placa="ZZZ1234", Categoria = 3 });

            //Assert
            Assert.IsTrue(retorno);

        }

        [TestMethod]
        public void comoDesenvolvedorQueroMeAutenticarNoServicoViaFacil()
        {
            //arrange
            IntegradorJBSSemParar.IntegradorJBS integradorJbs = new IntegradorJBSSemParar.IntegradorJBS();

            //act
            var retorno = integradorJbs.AutenticarUsuario("02914460011276", "ADMINISTRADOR", "grupostp");

            //assert
            Assert.IsTrue(retorno.sessao!=0);

        }

        [TestMethod]
        public void comoDesenvolvedorQueroRetornarStatusDeVeiculos() {

            //arrange
            IntegradorJBSSemParar.IntegradorJBS integradorJbs = new IntegradorJBSSemParar.IntegradorJBS();

            //act
            var token = integradorJbs.AutenticarUsuario("02914460011276", "ADMINISTRADOR", "grupostp");
            var retorno = integradorJbs.ConsultaStatusVeiculo(new IntegradorJBSSemParar.ServicoViaFacil.Veiculo { placa = "FHZ9752" }, token);

            //assert
            Assert.IsTrue(retorno.Count > 0);

        }
        



    }
}
