using System.Collections.Generic;
using System.Linq;

namespace MBCorpHealth.Dominio
{
    public class PlanoDeSaude
    {
        private readonly List<IServicoDeVerificacaoDeCobertura> _servicos;

        public PlanoDeSaude(List<IServicoDeVerificacaoDeCobertura> servicos)
        {
            _servicos = servicos;
        }

        public string CNPJ { get; private  set; }
        public string Nomedeplano { get; private set; }
        public string TipoDoPlano { get; private set; }

        public bool VerificarCobertura(Exame exame)
        {
            IServicoDeVerificacaoDeCobertura servicoDeVerificacaoDeCobertura;
            return _servicos.First(busca => busca.CNPJ == CNPJ).VerificarCoberturaDoExame(exame);
        }                                   
        }
    }