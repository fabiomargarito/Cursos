using System;
using System.Runtime.InteropServices;
using AplicacaoParaRefactoringCompraEVendaDeAcoes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveGravarCliente()
        {
            var cliente = new Cliente();
            cliente.CPF = "1234";
            cliente.Nome = "Fabio Margarito";

            var servicoDeCliente = new ServicoDeCliente(new RepositorioCliente());
            Assert.IsTrue(servicoDeCliente.GravarCliente(cliente));
        }
    }
}
