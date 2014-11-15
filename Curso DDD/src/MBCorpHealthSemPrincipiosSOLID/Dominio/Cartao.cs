using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBCorpHealth.Infraestrutura.Servico;

namespace MBCorpHealth.Dominio
{
    public class Cartao
    {
        public Cartao(string numeroDoCartao, string nomeConformeEscritoNoCartao, string codigoDeSeguranca)
        {
            NumeroDoCartao = numeroDoCartao;
            NomeConformeEscritoNoCartao = nomeConformeEscritoNoCartao;
            CodigoDeSeguranca = codigoDeSeguranca;
        }

        public bool RealizarPagamento(Cartao cartao, double valor)
        {
            ServicoDePagamentoMaster servicoDePagamento = new ServicoDePagamentoMaster();
            return servicoDePagamento.RealizarPagamento(cartao, valor);
        }

        public string NumeroDoCartao { get; private set; }
        public string NomeConformeEscritoNoCartao { get;private set; }
        public string CodigoDeSeguranca { get; private set; }
    }
}
