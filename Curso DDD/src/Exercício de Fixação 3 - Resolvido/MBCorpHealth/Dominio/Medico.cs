using System;
using System.Collections.Generic;

namespace MBCorpHealth.Dominio
{
    public class Medico : Pessoa
    {
        
        public string CRM { get; private set; }
        public ISet<EspecializacaoMedica> Especializacoes { get; private set; }

        public Medico(string nome, string cpf, string crm) : base(nome, cpf)
        {
            ValidarDadosDoMedico(crm);
            CRM = crm;
        }

        private void ValidarDadosDoMedico(string crm)
        {
            if (string.IsNullOrEmpty(crm)) throw new ArgumentNullException("É necessário informar o crm do médico!");
        }
                
        public void AdicionarEspecializacao(EspecializacaoMedica especializacaoMedica)
        {
            CriarListaDeEspecializacoesSeEstiverNula();
            
            Especializacoes.Add(especializacaoMedica);
        }

        private void CriarListaDeEspecializacoesSeEstiverNula()
        {
            if(Especializacoes==null)
                Especializacoes = new HashSet<EspecializacaoMedica>();
        }        
    }
}
