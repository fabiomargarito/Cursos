using System;
using MBCorpHealth.Aplicacao.Servico;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos;
using MBCorpHealth.Infraestrutura.Repositorio;
using MBCorpHealth.Infraestrutura.Repositorio.Fakes;
using MBCorpHealth.View.ViewModel;
using MBCorpHealthTest;
using Microsoft.Practices.Unity;
using NHibernate;

namespace MBCorpHealthUI
{
    class Program
    {
        static void Main(string[] args)
        {

            UnityContainer unityContainer = new UnityContainer();            
            unityContainer.RegisterType<IRepositorioPaciente, RepositorioPaciente>();
            unityContainer.RegisterInstance<ISession>(ConfiguracaoNHibernate.Criar().OpenSession());


            ServicoDePaciente servicoDePaciente = unityContainer.Resolve<ServicoDePaciente>();
            
            PacienteViewModel paciente = new PacienteViewModel{Cpf = "123",Nome = "teste"};
            
            servicoDePaciente.Gravar(paciente);
            

            Console.WriteLine("Paciente Gravado Com Sucesso");
            Console.ReadKey();

        }
    }
}
