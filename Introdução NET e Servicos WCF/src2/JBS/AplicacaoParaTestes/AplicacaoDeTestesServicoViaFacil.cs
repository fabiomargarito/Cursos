using IntegradorSistemaPedagio.Core;
using IntegradorSistemaPedagio.Servico;
using System;
using System.Windows.Forms;

namespace AplicacaoParaTestes
{
    public partial class AplicacaoDeTestesServicoViaFacil : Form
    {
        public AplicacaoDeTestesServicoViaFacil()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbComponente.Checked)
                {
                    IIntegradorSistemaPedagio integradorViaFacil = new IntegradorSistemaPedagioViaFacil();
                    txtMensagemSOAPRecebida.Text = integradorViaFacil.EnviarRequisicaoSOAP(txtMensagemSOAP.Text);
                }
                else {
                    using (ServicoIntegradorSistemaPedagio.IntegradorSistemaPedagioClient proxy = new ServicoIntegradorSistemaPedagio.IntegradorSistemaPedagioClient()) {
                        proxy.Open();
                        txtMensagemSOAPRecebida.Text=proxy.EnviarRequisicaoSOAP(txtMensagemSOAP.Text);
                    }
                    
                }
            }
            catch(Exception exception) {
                lblErro.Text = exception.Message;
            }
        }        
    }
}
