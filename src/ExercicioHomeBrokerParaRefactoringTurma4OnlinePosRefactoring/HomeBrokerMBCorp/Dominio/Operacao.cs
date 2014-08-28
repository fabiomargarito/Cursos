using System;
using System.Collections.Generic;

namespace HomeBrokerMBCorp.Dominio
{
    public class Operacao
    {
        public Acao Acao { get; private set; }    
        public double Valor{ get; private set; }
        public int Quantidade{ get; private set; }
        public Usuario Usuario{ get; private set; }
        public Corretora Corretora{ get; private set; }
        public IEstrategiaCorretagem Corretagem{ get; private set; }
        public IList<Imposto> Impostos{ get; private set; }
        public TipoOperacao TipoOperacao{ get; private set; }

        public Operacao(Acao acao, double valor, int quantidade, Usuario usuario, Corretora corretora, TipoOperacao tipoOperacao)
        {           

            Acao = acao;
            Valor = valor;
            Quantidade = quantidade;
            Usuario = usuario;
            Corretora = corretora;

            ValidarDadosDaOperacao();
        }
        
        public void AdicionarImpostos(Imposto imposto)
        {            
            Impostos.Add(imposto);
        }

        public void AdicionarCorretagem(IEstrategiaCorretagem corretagem)
        {
            Corretagem = corretagem;
        }

        private void ValidarDadosDaOperacao()
        {
            if (Acao == null)
                throw new ArgumentNullException("Favor informar uma ação");

            if (Valor <= 0)
                throw new ArgumentNullException("Valor da ação não pode ser zero ou menor");

            if (Quantidade <= 0)
                throw new ArgumentNullException("Quantidade não pode ser zero ou menor");

            if (Usuario == null)
                throw new ArgumentNullException("Favor informar o usuário");

            if (Corretora == null)
                throw new ArgumentNullException("Favor informar a corretora");
        }

        
    }

    class ServicoDeOperacao
    {
        public Operacao GerarOperacao(Acao acao, Cotacao cotacao, List<Imposto> mpostos, int quantidade,Usuario usuario,TipoOperacao tipoOperacao)
        {
            return new Operacao(acao,cotacao.Preco,10,quantidade,usuario,tipoOperacao);
        }
         
    }

}