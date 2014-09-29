using System;

namespace MBCORPHealthTests
{
    public class Endereco
    {
        public string Cep { get; private set; }        
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

        public Endereco(string cep, string endereco, string complemento, string bairro, string cidade, string estado)
        {
            if (string.IsNullOrEmpty(cep)) throw new Exception("cep inválido");
            if (string.IsNullOrEmpty(endereco)) throw new Exception("endereco inválido");
            if (string.IsNullOrEmpty(complemento)) throw new Exception("complemento inválido");
            if (string.IsNullOrEmpty(bairro)) throw new Exception("bairro inválido");
            if (string.IsNullOrEmpty(cidade)) throw new Exception("cidade inválido");
            if (string.IsNullOrEmpty(estado)) throw new Exception("estado inválido");

            Cep = cep;            
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public Endereco ConsultaEnderecoPorCEP(string cep, TipoServico tipoServico)
        {
            ConsultaCepBase consultaCep;
            if (tipoServico == TipoServico.Corporativo)
            {
                consultaCep = new ConsultaCepCorporativo();
                return consultaCep.Consultar(cep);
            }
            else if (tipoServico == TipoServico.Correios)
            {
                   consultaCep = new ConsultaCepCorporativo();
                (consultaCep as ConsultaCepCorreio).CodigoAcesso = "1234";
                return consultaCep.Consultar(cep);
            }

            return null;
        }
    }
}