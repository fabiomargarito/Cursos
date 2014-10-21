using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos;
using MBCorpHealth.Dominio.Contratos.Servicos;

namespace MBCorpHealth.Infraestrutura.Servico
{
    public class ServicoDePagamentoMaster : IServicoDePagamento
    {
        public  bool RealizarPagamento(Cartao cartao, double valor)
        {
            //conecta-se como servico da Cielo e realiza o pagamento
            return true;
        }

    }
}
