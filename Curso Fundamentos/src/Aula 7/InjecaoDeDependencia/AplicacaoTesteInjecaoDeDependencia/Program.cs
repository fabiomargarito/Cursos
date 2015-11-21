using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoTesteInjecaoDeDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 passo - criar o container
            UnityContainer container = new UnityContainer();

            //2 passo - registrar a inteligencia de solução das dependencias
            //container.RegisterType<ILog, Log>();
            container.RegisterInstance<ILog>(new Log());


            //3 passo - resolver as dependencias

            //Injecao de Dependencia por construtor
            ICMSSaoPaulo icmsSaoPaulo = container.Resolve<ICMSSaoPaulo>();
            icmsSaoPaulo.CalcularICMS(1000);


            //Injecao de Dependencia por setter
            ICMSSaoPauloV2 icmsSaoPauloV2 = container.Resolve<ICMSSaoPauloV2>();          
            icmsSaoPauloV2.CalcularICMS(1000);


            //Injecao de Dependencia por método
            ICMSSaoPauloV3 icmsSaoPauloV3 = container.Resolve<ICMSSaoPauloV3>();
            icmsSaoPauloV2.CalcularICMS(2000);
            Console.ReadKey();
        }
    }


    public interface ILog
    {
        void InserirLog(string mensagem);
    }

    public class Log : ILog
    {
        public void InserirLog(string mensagem) {
            Console.WriteLine(mensagem);
        }
    }

    public class LogVersao2 : ILog
    {
        public void InserirLog(string mensagem)
        {
            Console.WriteLine("Log versão 2:" + mensagem);
        }
    }

    //Injecao de dependencia por construtor
    public class ICMSSaoPaulo {

        private ILog _log;

        public ICMSSaoPaulo(ILog log) {
            _log = log;
        }

        public double CalcularICMS(double valor) {            

            var valorICMS = valor * 0.25;

            _log.InserirLog(string.Format("O valor de ICMS para {0}, é de {1}.",valor,valorICMS));

            return valorICMS;

        }
    }


    //Injecao de dependencia por setter
    public class ICMSSaoPauloV2
    {
        

        [Dependency]
        public ILog log { get; set; }

        public double CalcularICMS(double valor)
        {

            var valorICMS = valor * 0.25;

            log.InserirLog(string.Format("O valor de ICMS para {0}, é de {1}.", valor, valorICMS));

            return valorICMS;

        }
    }


    //Injecao de dependencia por método
    public class ICMSSaoPauloV3
    {

        private ILog _log;

        [InjectionMethod]
        public void InserirDependenciaPorMetodo(ILog log) {
            _log = log;
        }


        
        public double CalcularICMS(double valor)
        {

            var valorICMS = valor * 0.25;

            _log.InserirLog(string.Format("O valor de ICMS para {0}, é de {1}.", valor, valorICMS));

            return valorICMS;

        }
    }






}
