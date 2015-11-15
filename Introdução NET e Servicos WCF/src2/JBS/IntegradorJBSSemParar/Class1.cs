using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorJBSSemParar
{
    public class IntegradorJBS
    {
        public List<ServicoDeDados.Veiculo> RetornarTodosOsVeiculos() {
            ServicoDeDados.DadosVeiculoClient servico = new ServicoDeDados.DadosVeiculoClient();
            servico.Open();
            return servico.retornarVeiculos().ToList<ServicoDeDados.Veiculo>();
        }

        public ServicoViaFacil.Identificador AutenticarUsuario(string cnpj, string usuario, string senha) {
            ServicoViaFacil.ValePedagioClient servico = new ServicoViaFacil.ValePedagioClient();
            servico.Open();
            return servico.autenticarUsuario(cnpj, usuario, senha);
            
        }

        public List<ServicoViaFacil.Veiculo> ConsultaStatusVeiculo(ServicoViaFacil.Veiculo veiculo, ServicoViaFacil.Identificador identificador) {
            ServicoViaFacil.ValePedagioClient servico = new ServicoViaFacil.ValePedagioClient();
            servico.Open();
            return servico.obterStatusVeiculo(veiculo.placa, identificador.sessao).ToList<ServicoViaFacil.Veiculo>();
        }
    }
}
