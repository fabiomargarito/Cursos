using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos;

namespace MBCorpHealth.Infraestrutura.Servico
{
    public class ServicoDePagamentoMaster : ServicoDePagamento
    {
        public override bool RealizarPagamento(Cartao cartao, double valor)
        {
            //conecta-se como servico da Cielo e realiza o pagamento
            Console.WriteLine("Pagamento com Master");
            return true;
        }


    }
}
