using System;
using System.Data;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos;
using MBCorpHealth.Dominio.Contratos.Servicos;

namespace MBCorpHealth.Infraestrutura.Servico
{



   public class ServicoDePagamentoDinners : IServicoDePagamento
    {
        

        public  bool RealizarPagamento(Cartao cartao, double valor)
        {
            //conecta-se como servico da Cielo e realiza o pagamento
            return true;
        }


    }
}
