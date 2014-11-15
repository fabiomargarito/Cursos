using System;

namespace MBCorpHealth.Dominio
{

    public interface IServicoDeBuscaDeEndereco
    {
        Endereco Buscar(string cep);
    }

    public class ServicoBuscaDadosEnderecoCorporativo:IServicoDeBuscaDeEndereco
    {
        public Endereco Buscar(string cep)
        {
            Console.WriteLine("Buscando CEP no serviço corporativo");
            return new Endereco("rua 1", "casa 1", "vila madalena", "São Paulo", "SP", "02234143");
        }
    }


    public class ServicoBuscaDadosEnderecoCorreios:IServicoDeBuscaDeEndereco
    {
        public Endereco Buscar(string cep)
        {
            Console.WriteLine("Buscando CEP no serviço dos correios");
            return new Endereco("rua 1", "casa 1", "vila madalena", "São Paulo", "SP", "02234143");
        }
    }

    public class Endereco
    {
        public Endereco(string logradouro, string complemento, string bairro, string municipio, string estado, string cep)
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


        public Endereco ConsultarEnderecoNosCorreios(string cep, TipoServicoDeConsulta tipoServicoDeConsulta)
        {
            IServicoDeBuscaDeEndereco servicoDeBuscaDeEndereco = null;

            switch (tipoServicoDeConsulta)
            {
                case TipoServicoDeConsulta.ServicoCorporativo:
                    servicoDeBuscaDeEndereco = new ServicoBuscaDadosEnderecoCorporativo();break;
                case TipoServicoDeConsulta.ServicoCorreios: servicoDeBuscaDeEndereco = new ServicoBuscaDadosEnderecoCorreios();break;
                default: throw new Exception("Servico Selecionado inválido");
            }

            return servicoDeBuscaDeEndereco.Buscar(cep);

            return null;
        }
    }
}