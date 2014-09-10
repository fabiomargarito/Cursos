using System;

namespace MBCORPHealthTests
{
    public class Endereco
    {
        public Endereco()
        {
        }

        public virtual int ID { get; protected set; }
        public virtual string Logradouro { get; protected set; }        
        public virtual string Cep { get; protected set; }        
        public virtual string Complemento { get; protected set; }
        public virtual string Bairro { get; protected set; }
        public virtual string Cidade { get; protected set; }
        public virtual string Estado { get; protected set; }

        public  Endereco(string cep, string logradouro, string complemento, string bairro, string cidade, string estado)
        {
            if (string.IsNullOrEmpty(cep)) throw new Exception("cep inválido");
            if (string.IsNullOrEmpty(logradouro)) throw new Exception("Logradouro inválido");
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

        public virtual Endereco ConsultaEnderecoPorCEP(string cep, TipoServico tipoServico)
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