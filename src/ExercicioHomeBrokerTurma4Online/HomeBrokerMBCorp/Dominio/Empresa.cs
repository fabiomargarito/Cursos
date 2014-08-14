using System.Collections.Generic;

namespace HomeBrokerMBCorp.Dominio
{
    public class Empresa
    {
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public List<Acao> Acoes { get; set; }
    }
}