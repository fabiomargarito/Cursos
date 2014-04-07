    using System.Configuration;

namespace Singleton
{
    public class Configuracao    {
        private static  Configuracao _instanciaDesteObjeto;
        private string _nomeDoBancoDeDados;

        public string NomeDoBancoDeDados
        {
            get { return _nomeDoBancoDeDados; }
            private set { _nomeDoBancoDeDados = NomeDoBancoDeDados;
                
            }
        }

        private Configuracao() {
            NomeDoBancoDeDados = ConfigurationManager.AppSettings["NomeDoBancoDeDados"].ToString(); ;
        }

        public static Configuracao RetornarConfiguracao(){            
            if (_instanciaDesteObjeto == null) {
                _instanciaDesteObjeto = new Configuracao();                
            }                
            
            return _instanciaDesteObjeto;
        }

        public string RetornarNomeDoBancoDeDados()
        {
            return NomeDoBancoDeDados;
           
        }
    }
}
