using System;
using System.Collections;
using System.Collections.Generic;
using JBSHealthCare.Aplicacao.Servico.BoundedContextCalendarios;
using JBSHealthCare.Aplicacao.Servico.BoundedContextGestaoDeAgendamentos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestesUnitarios
{
    [TestClass]
    public class BoundedContextCalendariosTestesUnitarios
    {
        [TestMethod]
        public void ComoAtendenteEuQueroAgendaDoCentroDeDiagnostico()
        {
            //Arrange
            ServicoDeCalendario servicoDeCalendario  = new ServicoDeCalendario();

            //Act

            IList<DateTime> datas = servicoDeCalendario.Consultar(10);

            //Assert

            Assert.IsTrue(datas.Count>0);
        }
    }
}
