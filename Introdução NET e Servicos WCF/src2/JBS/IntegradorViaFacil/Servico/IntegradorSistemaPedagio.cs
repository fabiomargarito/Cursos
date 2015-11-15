using IntegradorSistemaPedagio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Configuration;

namespace IntegradorSistemaPedagio.Servico
{
    public class IntegradorSistemaPedagioViaFacil : IIntegradorSistemaPedagio
    {
        public string EnviarRequisicaoSOAP(string mensagemSOAP)
        {
            //Montando a requisição
            var request = WebRequest.Create(ConfigurationManager.AppSettings["EnderecoServicoIntegracaoPedagio"]);
            request.Method = "POST";
            byte[] byteArray = Encoding.UTF8.GetBytes(mensagemSOAP);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            request.Headers.Add("SOAPAction", "");

            //Carregando o conteúdo da variável texto mensagemSOAP para dentro da requisição
            using (Stream dataStreamRequisicao = request.GetRequestStream())
            {
                dataStreamRequisicao.Write(byteArray, 0, byteArray.Length);
                dataStreamRequisicao.Close();
            }

            //Enviando a requisição e recebendo a resposta
            using (WebResponse response = request.GetResponse())
            {
                //Lendo o fluxo de dados da resposta
                using (Stream dataStreamResposta = response.GetResponseStream())
                //{
                    //Lendo os bytes e convertendo em string
                    using (StreamReader reader = new StreamReader(dataStreamResposta))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }

        }
    }

