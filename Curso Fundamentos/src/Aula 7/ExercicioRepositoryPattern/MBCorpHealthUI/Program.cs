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

namespace MBCorpHealthUI
{
    class Program
    {
        static void Main(string[] args)
        {

            UnityContainer unity = new UnityContainer();

            unity.RegisterType<IRepositorioAgendamento, Agendamentos>();
            unity.RegisterType<IRepositorio<Paciente>, PacientesSQL>();
            unity.RegisterType<IServicoDePagamento, ServicoDePagamentoMaster>();


            ServicoDeConsultaDeDadosDePaciente servicoDeConsultaDeDadosDePaciente = unity.Resolve<ServicoDeConsultaDeDadosDePaciente>();
            
           
            var retorno = servicoDeConsultaDeDadosDePaciente.RetornarResultadosDeExame("284434343434334");
            

            foreach (ResultadoViewModel resultado in retorno)
            {
                Console.Write(resultado.Descricao);
            }

            Console.ReadKey();

        }
    }
}
