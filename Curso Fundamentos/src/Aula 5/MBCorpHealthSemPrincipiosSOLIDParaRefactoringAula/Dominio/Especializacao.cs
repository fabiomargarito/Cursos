using System;

namespace MBCorpHealth.Dominio
{
    public class EspecializacaoMedica
    {
        public string Nome { get; private set; }
        
        public EspecializacaoMedica(string nome)
        {
            ValidarDadosDaEspecializacaoMedica(nome);
            Nome = nome;
        }

        private void ValidarDadosDaEspecializacaoMedica(string nome)
        {
            if (string.IsNullOrEmpty(nome)) throw new ArgumentNullException("É necessário informar o nome da especialização médica!");
        }        
    }



    class Estado
    {
        public Estado(string sigla) {
            Sigla = sigla;
        }
        public string Sigla { get; private set; }
    }


    class Fornecedor {

        public string Endereco { get; private set; }

        public void DefineEndereco(string cep) {
            Endereco = (new ServicoDebuscaDeEnderecoNosCorreios()).buscaEnderecoNosCorreios(cep);
        }

        

        public class ServicoDebuscaDeEnderecoNosCorreios {
            public  string buscaEnderecoNosCorreios(string cep)
            {
                //vai nos correios, busca o endereco
                return "retorno do endereco dos correios";
            }
        }
    }

}