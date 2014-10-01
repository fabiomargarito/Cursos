using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MBCorpHealth.Dominio
{
    public class Endereco
    {
        public Endereco(string logradouro, string complemento, string bairro, string municipio, string estado,
            string cep)
        {
            Logradouro = logradouro;
            Complemento = complemento;
            Bairro = bairro;
            Municipio = municipio;
            Estado = estado;
            CEP = cep;
            
        }

        public string Logradouro { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Municipio { get; private set; }
        public string Estado { get; private set; }
        public string CEP { get; private set; }
        public IList<ServicoConsultaEndereco> ServicosDeConsultaEnderecos { get; private set; }

        public void DefinirServicosDeConsultaDeEndereco(
            IList<ServicoConsultaEndereco> servicoConsultaDeConsultaEnderecos)
        {
            ServicosDeConsultaEnderecos = servicoConsultaDeConsultaEnderecos;
        }

        public Endereco ConsultarEnderecoPorCEP(string cep, string nomeServico)
        {
            ServicoConsultaEndereco servicoConsultaEndereco;
            return ServicosDeConsultaEnderecos.FirstOrDefault(servico => servico.NomeServico == nomeServico)
                .ConsultarEnderecoPorCEP(cep);
        }
    }

    public abstract class ServicoConsultaEndereco
        {
            public string NomeServico { get; set; }
            public abstract Endereco ConsultarEnderecoPorCEP(string cep);
        }



    public class ServicoConsultaEnderecoCorreios : ServicoConsultaEndereco
        {
            public override Endereco ConsultarEnderecoPorCEP(string cep)
            {
                //consultaria serviço web dos correios
                return new Endereco("rua 1", "casa 1", "vila madalena", "São Paulo", "SP", "02234143");
            }
        }

    public class ServicoConsultaEnderecoCorporativo : ServicoConsultaEndereco
        {
            public override Endereco ConsultarEnderecoPorCEP(string cep)
            {
                //consultaria serviço corporativo
                return new Endereco("rua 1", "casa 1", "vila madalena", "São Paulo", "SP", "02234143");
            }
        }

    public class ServicoConsultaEnderecoCorporativoAtual : ServicoConsultaEndereco
        {
            public override Endereco ConsultarEnderecoPorCEP(string cep)
            {
                //consultaria serviço corporativo atual
                return new Endereco("rua 1", "casa 1", "vila madalena", "São Paulo", "SP", "02234143");
            }
        }

    public class ServicoConsultaEnderecoCorporativoAtualAtualizado : ServicoConsultaEndereco
        {
            public override Endereco ConsultarEnderecoPorCEP(string cep)
            {
                //consultaria serviço corporativo atual
                return new Endereco("rua 1", "casa 1", "vila madalena", "São Paulo", "SP", "02234143");
            }
        }
    
}