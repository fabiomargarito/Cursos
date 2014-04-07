using System;
using System.Runtime.Remoting.Messaging;
using Autofac;
using Dominio;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;

namespace ExemploModulo3InjecaoDeDependencia
{
    [TestClass]
    public class TestesUnitarios
    {
       #region Unity
            [TestMethod]
            public void DeveRegistrarOperacaoDeCompraUtilizandoUnityConstructorInjection()
            {           
                var container = new UnityContainer();


                container.RegisterType<ILog, LogNovo>();
                container.RegisterType <IRepositorio<Carteira>,RepositorioCarteiraFake>();
                CarteiraService carteiraService = container.Resolve<CarteiraService>();

                Assert.IsTrue(
                    carteiraService.RegistrarOperacaoDeCompra(new Operacao(), new Carteira())
                    ) ;
            }
            
            [TestMethod]
            public void DeveGravarCorretoraUtilizandoUnityMethodInjection()
            {
                var container = new UnityContainer();
                container.RegisterType<IRepositorio<Corretora>, RepositorioCorretoraFake>();
                var corretora = container.Resolve<Corretora>();
                corretora.Nome = "Corretora Teste";
                Assert.IsTrue(corretora.Gravar());
            }


            [TestMethod]
            public void DeveGravarCorretoraUtilizandoUnitySetterInjection()
            {
                var container = new UnityContainer();
                container.RegisterType<IRepositorio<Cliente>, RepositorioClienteFake>();
                var cliente  = container.Resolve<Cliente>();
                cliente.Nome = "Corretora Teste";
                Assert.IsTrue(cliente.Gravar());
            }

        #endregion
       #region Ninject
            [TestMethod]
            public void DeveRegistrarOperacaoDeCompraUtilizandoNinjectConstructorInjection()
            {   
                using (IKernel kernel = new StandardKernel())
                {
                    kernel.Bind<ILog>().To<Log>().InTransientScope();
                    kernel.Bind<IRepositorio<Carteira>>().To<RepositorioCarteiraFake>().InTransientScope();

                    CarteiraService carteiraService = kernel.Get<CarteiraService>();
                    Assert.IsTrue(
                        carteiraService.RegistrarOperacaoDeCompra(new Operacao(), new Carteira())
                        );
                }
             }
            
            [TestMethod]
            public void DeveGravarClienteUtilizandoNinjectSetterInjection()
            {
                using (IKernel kernel = new StandardKernel())
                {
                    kernel.Bind<IRepositorio<Cliente>>().To<RepositorioClienteFake>();                    
                    var cliente = kernel.Get<Cliente>();
                    cliente.Nome = "Cliente Teste";
                    Assert.IsTrue(cliente.Gravar());
                }
            }
            
            [TestMethod]
            public void DeveGravarCorretoraUtilizandoNinjectMethodInjection()
            {
                using (IKernel kernel = new StandardKernel())
                {
                    kernel.Bind<IRepositorio<Corretora>>().To<RepositorioCorretoraFake>();
                    var corretora = kernel.Get<Corretora>();
                    corretora.Nome = "Corretora Teste";
                    Assert.IsTrue(corretora.Gravar());
                }
            }
        
       #endregion Ninject
       #region Autofac

        [TestMethod]
        public void DeveRegistrarOperacaoDeCompraUtilizandoAutofacConstructorInjection()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<CarteiraService>().AsSelf();
            builder.RegisterType<Log>().As<ILog>();
            builder.RegisterType<RepositorioCarteiraFake>().As<IRepositorio<Carteira>>();
            
            var container = builder.Build();

            using (container.BeginLifetimeScope())
            {
                CarteiraService carteiraService = container.Resolve<CarteiraService>();
                Assert.IsTrue(
                        carteiraService.RegistrarOperacaoDeCompra(new Operacao(), new Carteira())
                        );
            }
        }

        [TestMethod]
        public void DeveGravarClienteUtilizandoAutofacSetterInjection()
        {
            var builder = new ContainerBuilder();            
            builder.RegisterType<RepositorioClienteFake>().As<IRepositorio<Cliente>>();
            builder.RegisterType<Cliente>().PropertiesAutowired();


            var container = builder.Build();


            using (container.BeginLifetimeScope())
            {
                var cliente = container.Resolve<Cliente>();
                cliente.Nome = "Cliente Teste";
                Assert.IsTrue(cliente.Gravar());
            }
        }


        [TestMethod]
        public void DeveGravarCorretoraUtilizandoAutofactMethodInjection()
        {

            var builder = new ContainerBuilder();
            builder.RegisterType<RepositorioCorretoraFake>().As<IRepositorio<Corretora>>();
            builder.RegisterType<Corretora>().OnActivating(e =>
            {
                var dep = e.Context.Resolve<IRepositorio<Corretora>>();
                e.Instance.Inicializar(dep);
            }
            );

            var container = builder.Build();
            using (container.BeginLifetimeScope())
            {
                var corretora = container.Resolve<Corretora>();
                corretora.Nome = "Corretora Teste";
                Assert.IsTrue(corretora.Gravar());
            }
        }

        #endregion
    }
}
