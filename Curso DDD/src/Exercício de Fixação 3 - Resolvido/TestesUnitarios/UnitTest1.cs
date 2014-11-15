using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestesUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveGravarUmAtendente()
        {
            ServicoAtendente servicoAtendente = new ServicoAtendente(new RepositorioAtendenteFake());
            AtendenteViewModel atendente = new AtendenteViewModel("Fabio","2345",1234);
            var retorno = servicoAtendente.gravar(atendente);                        
            Assert.IsTrue(retorno==true);
        }
    }
}
