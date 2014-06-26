using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Carteira
    {
        //private List<Operacao> _operacoes = new List<Operacao>();

        public virtual int ID { get; set; }


        public Carteira()
        {
            Operacoes = new List<Operacao>();
        }


        //public virtual List<Operacao> Operacoes
        //{
        //    get { return _operacoes; }
        //    private set
        //    {                
        //        _operacoes = value;
        //    }
        //}


        public IList<Operacao> Operacoes { get; set; }



        public virtual bool RegistarOperacaoDeCompra(Acao acao, double valor, int quantidadeDeAcoes, DateTime dataDaOperacao)
        {
            Operacao operacao = new Operacao();
            operacao.Tipo = TipoOperacao.C;
            operacao.Acao = acao;
            operacao.Quantidade = quantidadeDeAcoes;
            operacao.Data = dataDaOperacao;
            operacao.Valor = operacao.Quantidade * valor;

            Operacoes.Add(operacao);

            Gravar();

            return true;
        }



        public virtual bool RegistarOperacaoDeVenda(Acao acao, double valor, int quantidadeDeAcoes, DateTime dataDaOperacao)
        {
            Operacao operacao = new Operacao();
            operacao.Tipo = TipoOperacao.V;
            operacao.Acao = acao;
            operacao.Quantidade = quantidadeDeAcoes;
            operacao.Data = dataDaOperacao;
            operacao.Valor = operacao.Quantidade * valor;

            Operacoes.Add(operacao);

            Gravar();

            return true;
        }


        public virtual void Gravar()
        {

        }

        public virtual Carteira RetornarPorPeriodo(DateTime time, object dateTime)
        {
            return new Carteira();

        }

        public virtual double CalcularImpostoDeRenda()
        {
            return 2000;
        }
    }
}
