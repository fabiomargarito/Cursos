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
    }
}