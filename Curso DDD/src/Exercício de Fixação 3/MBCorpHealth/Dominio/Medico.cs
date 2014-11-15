using System;
using System.Collections.Generic;

namespace MBCorpHealth.Dominio
{
    public class Medico : Pessoa
    {
        public Medico()
        {
        }

        public virtual string Conselho { get;  set; }
        //public ISet<EspecializacaoMedica> Especializacoes { get; private set; }

        public Medico(string nome, string cpf, string conselho) : base(nome, cpf)
        {
            ValidarDadosDoMedico(conselho);
            Conselho = conselho;
        }

        protected virtual void ValidarDadosDoMedico(string crm)
        {
            if (string.IsNullOrEmpty(crm)) throw new ArgumentNullException("É necessário informar o crm do médico!");
        }
                
        //public void AdicionarEspecializacao(EspecializacaoMedica especializacaoMedica)
        //{
        //    CriarListaDeEspecializacoesSeEstiverNula();
            
        //    Especializacoes.Add(especializacaoMedica);
        //}

        //private void CriarListaDeEspecializacoesSeEstiverNula()
        //{
        //    if(Especializacoes==null)
        //        Especializacoes = new HashSet<EspecializacaoMedica>();
        //}        
    }
    
}
