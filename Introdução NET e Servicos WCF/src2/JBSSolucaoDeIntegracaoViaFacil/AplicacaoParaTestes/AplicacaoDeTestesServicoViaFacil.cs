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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEnviarPostHttp_Click(object sender, EventArgs e)
        {
            try
            {
                IIntegradorSistemaPedagio integradorViaFacil = new IntegradorSistemaPedagioViaFacil();
                txtRetornoHTTP.Text = integradorViaFacil.EnviarRequisicaoPostHttp(txtEnderecoHTTP.Text, txtParametrosPostHttp.Text);
            }
            catch (Exception exception)
            {
                lblErro2.Text = exception.Message;
            }
        }

        private void txtMensagemSOAPRecebida_TextChanged(object sender, EventArgs e)
        {

        }

        private void AplicacaoDeTestesServicoViaFacil_Load(object sender, EventArgs e)
        {

        }
    }
}
