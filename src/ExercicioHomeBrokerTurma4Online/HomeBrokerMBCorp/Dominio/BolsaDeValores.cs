using System;
using System.Collections.Generic;

namespace HomeBrokerMBCorp.Dominio
{
    public class Acao
    {
        public string Codigo { get; set; }
        public Cotacao Cotacao { get; set; }
        public Empresa Empresa { get; set; }
    }

    public class Corretora
    {
        public string CNPJ { get; set; }
        public string Nome { get; set; }
    }

    
    public class Usuario
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
    }

    public class Custo
    {
        public TipoCusto TipoCusto { get; set; }
        public double Valor { get; set; }
    }

    public enum TipoCusto
    {
        Emolumento=0,
        TaxaCorretagem=1,
        IRDaytrade=2,
        IR=3
    }

    public class Carteira
    {
        public IList<Operacao> Operacoes { get; set; }
        public Usuario Usuario { get; set; }
    }

    public class Operacao
    {
        public Acao Acao { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public Usuario Usuario { get; set; }
        public Corretora Corretora { get; set; }
    }

    public class Ordem
    {
        public Acao Acao { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public Usuario Usuario { get; set; }
        public TipoOperacao TipoOperacao {get; set; }
    }

    public enum TipoOperacao
    {
        Compra=0,
        Venda=1
    }

    public class Cotacao
    {
        public double Preco { get; set; }
        public double ValorDeAbertura { get; set; }
        public double ValorDeFechamento { get; set; }
        public double Oscilacao { get; set; }
        public double Volume { get; set; }
        public DateTime HoraDaCotacao { get; set; }     

    }

    public class Empresa
    {
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public List<Acao> Acoes { get; set; }
    }

    public class BolsaDeValores
    {
        public string Nome { get; set; }
    }
}

