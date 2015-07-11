using System;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos.Repositorio;
using MBCorpHealth.Infraestrutura.Repositorio;
using MBCorpHealthUnitTest;
using Microsoft.Practices.Unity;

namespace MBCorpHealthUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ISessaoORM<ISessionFake> sessao = new SessaoFake();

            //Cria a caixa d'agua, que chamamos de container
            UnityContainer unityContainer = new UnityContainer();

            //encher a caixa d'agua, que chamados de registrar os componentes

            unityContainer.RegisterInstance(sessao);            
            unityContainer.RegisterType<IRepositorio<Paciente>, PacientesFake>();
            unityContainer.RegisterType<IRepositorio<Cartao>, RepositorioCartao>();

            Paciente paciente = new Paciente("fabio", Guid.NewGuid().ToString()) {Apelido = "teste"};
            IRepositorio<Paciente> pacientes = unityContainer.Resolve<IRepositorio<Paciente>>();            
            pacientes.Gravar(paciente);

            var retorno = pacientes.RetornarTodos();
     
            pacientes.Dispose();

            
            Console.Write("Consultas e gravações!!!!");
            Console.ReadKey();
            
        }
    }
}
