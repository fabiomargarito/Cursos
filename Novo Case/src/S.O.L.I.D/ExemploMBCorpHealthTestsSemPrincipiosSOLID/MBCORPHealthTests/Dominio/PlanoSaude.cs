using System;
using System.Security.Cryptography.X509Certificates;

namespace MBCORPHealthTests
{
    public class PlanoSaude
    {
        public string RazaoSocial { get; private set; }
        public string CNPJ { get; private set; }


        public PlanoSaude(string nome, string cnpj)
        {
            if (string.IsNullOrEmpty(nome)) throw new Exception("RazaoSocial inválido");
            if (string.IsNullOrEmpty(CNPJ)) throw new Exception("CNPJ inválido");

            RazaoSocial = nome;
            CNPJ = cnpj;
        }

        //Consultará os serviços dos planos de saúde
        public bool ConsultarCobertura(TipoExame tipoExame)
        {            
            ServicoConsultaCoberturaPlanoPortoSeguro servicoConsultaCoberturaPlanoPortoSeguro = new ServicoConsultaCoberturaPlanoPortoSeguro();
            return servicoConsultaCoberturaPlanoPortoSeguro.ConsultarCoberturaParaOExame(tipoExame);
        }

    }
}
