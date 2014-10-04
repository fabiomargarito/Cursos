using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MBCorpHealth.Dominio
{
    public class Endereco
    {
        public string Logradouro { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Municipio { get; private set; }
        public string Estado { get; private set; }
        public string CEP { get; private set; }
        public IList<ServicoConsultaEndereco> ServicosDeConsultaEnderecos { get; private set; }

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

        public void DefinirServicosDeConsultaDeEndereco(
            IList<ServicoConsultaEndereco> servicoConsultaDeConsultaEnderecos)
        {
            ServicosDeConsultaEnderecos = servicoConsultaDeConsultaEnderecos;
        }

        //Substituímos o swith/if por uma consulta linq que busca o serviço desejado pelo cliente da api pelo nome
        public Endereco ConsultarEnderecoPorCep(string cep, string nomeServico)
        {
            ServicoConsultaEndereco servicoConsultaEndereco;
            
            return ServicosDeConsultaEnderecos.FirstOrDefault(servico => servico.NomeServico == nomeServico)
                .ConsultarEnderecoPorCep(cep);
        }
    }
}