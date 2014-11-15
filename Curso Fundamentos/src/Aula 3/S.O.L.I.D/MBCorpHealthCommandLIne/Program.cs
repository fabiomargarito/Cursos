using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos;
using MBCorpHealth.Infraestrutura.Servico;

namespace MBCorpHealthCommandLIne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PlanoDeSaudeBase> planosDeSaude = new List<PlanoDeSaudeBase>();

            planosDeSaude.Add(new PlanoDePreventSenior{CNPJ = "002.002.0002/00002-20" });
            planosDeSaude.Add(new PlanoDeSaudeAmil{CNPJ = "003.003.0003/00003-30"});
            planosDeSaude.Add(new PlanoDeSaudePortoSeguro{CNPJ= "004.004.0004/00004-40"});
            planosDeSaude.Add(new PlanoDeSaudeSulAmerica{CNPJ="005.005.0005/00005-50"});
            planosDeSaude.Add(new PlanoDeSaudeBradesco{CNPJ = "006.006.0006/00006-0"});



            Paciente paciente = new Paciente("Fabio Margarito", "294.3434.3434");
            paciente.DefinirPlanoDeSaude((new FabricaDePlanos(planosDeSaude)).RetornarPlanoPorCNPJ("006.006.0006/00006-0"));


            ServicoDePagamento servicoDePagamento = new ServicoDePagamentoVisa();
            servicoDePagamento.ClienteVIP = true;            
            servicoDePagamento.RealizarPagamento(new Cartao("1234","fabio","123"),100 );

            Console.ReadKey();





        }
    }
}
