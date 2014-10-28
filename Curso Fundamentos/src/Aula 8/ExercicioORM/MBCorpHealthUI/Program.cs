using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBCorpHealth.Aplicacao.Servico;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos.Repositorio;
using MBCorpHealth.Dominio.Contratos.Servicos;
using MBCorpHealth.Infraestrutura.Repositorio;
using MBCorpHealth.Infraestrutura.Servico;
using MBCorpHealthUnitTest;
using Microsoft.Practices.Unity;
using NHibernate;

namespace MBCorpHealthUI
{
    class Program
    {
        static void Main(string[] args)
        {
      
            using (ISession session = ConfiguracaoNHibernate.Criar().OpenSession())
            {

                IRepositorio<Cartao> cartaoRepositorio = new RepositorioCartao(session);

                cartaoRepositorio.Gravar(new Cartao("12345", "fabio margarito", "1234"));

                cartaoRepositorio.Gravar(new Cartao("bbb", "fabio barros", "123"));

            }

            //    UnityContainer unity = new UnityContainer();

            //    unity.RegisterType<IRepositorioAgendamento, Agendamentos>();
            //    unity.RegisterType<IRepositorio<Paciente>, Pacientes>();
            //    unity.RegisterType<IServicoDePagamento, ServicoDePagamentoMaster>();


            //    ServicoDeConsultaDeDadosDePaciente servicoDeConsultaDeDadosDePaciente = unity.Resolve<ServicoDeConsultaDeDadosDePaciente>();


            //    var retorno = servicoDeConsultaDeDadosDePaciente.RetornarResultadosDeExame("284434343434334");


            //    foreach (ResultadoViewModel resultado in retorno)
            //    {
            //        Console.Write(resultado.Descricao);
            //    }

            
            Console.Write("Cartoes Gravados!!!!");
            Console.ReadKey();

            //
        }
    }
}
