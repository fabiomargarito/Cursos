using System;
using System.Collections.Generic;
using FluentNHibernate.Testing.Values;
using MBCorpHealthTest.Infraestrutura.ContextoBooking;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MBCorpHealthTestTest
{
    [TestClass]
    public class TestesUnitariosContextoBooking
    {
        [TestMethod]
        public void ComoUsuarioDoServicoDeAgendamentoQueroAAgendaDisponivelParaUmTipoDeExameEUmCentroDeDiagnostico()
        {
            //Arrange
            IServicoDeBooking servicoDeBooking = new ServicoDeBookingFake();  

            //Act

            IEnumerable<DateTime> agenda = servicoDeBooking.Verificar("1234",1234);
            
            //Assert
            Assert.IsTrue((agenda as IList<DateTime>).Count > 0);

        }
    }
}
