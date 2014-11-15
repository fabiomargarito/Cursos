using System.Configuration;

namespace Singleton {
    //Singleton
    public class Configuracao {
                
        private static Configuracao _instanciaDesteObjeto;
        
        private string _nomeDoBancoDeDados;

        public string NomeDoBancoDeDados {
            get { return _nomeDoBancoDeDados; }
            private set {
                _nomeDoBancoDeDados = value;

            }
        }

        private Configuracao() {
            NomeDoBancoDeDados = ConfigurationManager.AppSettings[0];
        }

        public static Configuracao RetornarConfiguracao() {
            if (_instanciaDesteObjeto == null) {
                _instanciaDesteObjeto = new Configuracao();
            }

            return _instanciaDesteObjeto;
        }

        public string RetornarNomeDoBancoDeDados() {
            return NomeDoBancoDeDados;

        }

        public void Expirar()
        {
            _instanciaDesteObjeto = null;
        }
    }
}
