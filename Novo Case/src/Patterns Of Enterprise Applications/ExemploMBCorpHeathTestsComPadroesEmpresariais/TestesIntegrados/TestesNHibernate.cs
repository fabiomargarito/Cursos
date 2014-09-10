using System;
using System.Runtime.InteropServices;
using MBCORPHealthTests;
using MBCORPHealthTests.Infraestrutura;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestesIntegrados
{
    [TestClass]
    public class TestesNHibernate
    {
        [TestMethod]
        public void DeveGravarUmPacienteNaBase()
        {
            var endereco = new Endereco("02223160", "Rua de teste", "sem complemento", "cambuí", "São Paulo", "SP");
            var credencial = new CredencialAcesso("fmbarros", "12345");
            var planoDeSaude = new PlanoSaude("Porto Seguro", "123");
            var paciente = new Paciente("Fabio Margarito Martins de Barros", "24349298212");
            paciente.AdicionarEndereco(endereco);
            paciente.DefinirPlanoDeSaude(planoDeSaude);
            paciente.DefinirCredencialDeAcesso(credencial);


            using (var session = NHibernateSessionFactory.Criar().OpenSession())
            {
                session.SaveOrUpdate(paciente);
                session.Flush();
            }
        }
    }
}
