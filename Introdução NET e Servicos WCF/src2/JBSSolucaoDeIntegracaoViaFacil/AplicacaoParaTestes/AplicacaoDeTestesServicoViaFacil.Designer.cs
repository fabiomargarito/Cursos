namespace AplicacaoParaTestes
{
    partial class AplicacaoDeTestesServicoViaFacil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AplicacaoDeTestesServicoViaFacil));
            this.txtMensagemSOAP = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtMensagemSOAPRecebida = new System.Windows.Forms.TextBox();
            this.lblMensagemSoap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTipoRequisicao = new System.Windows.Forms.GroupBox();
            this.rbServico = new System.Windows.Forms.RadioButton();
            this.rbComponente = new System.Windows.Forms.RadioButton();
            this.lblErro = new System.Windows.Forms.Label();
            this.txtEnderecoHTTP = new System.Windows.Forms.TextBox();
            this.lblEnderecoHttp = new System.Windows.Forms.Label();
            this.txtParametrosPostHttp = new System.Windows.Forms.TextBox();
            this.lblParametrosPostHttp = new System.Windows.Forms.Label();
            this.btnEnviarPostHttp = new System.Windows.Forms.Button();
            this.txtRetornoHTTP = new System.Windows.Forms.TextBox();
            this.lblRetornoHTTP = new System.Windows.Forms.Label();
            this.lblErro2 = new System.Windows.Forms.Label();
            this.gbTipoRequisicao.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMensagemSOAP
            // 
            this.txtMensagemSOAP.Location = new System.Drawing.Point(12, 35);
            this.txtMensagemSOAP.Multiline = true;
            this.txtMensagemSOAP.Name = "txtMensagemSOAP";
            this.txtMensagemSOAP.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMensagemSOAP.Size = new System.Drawing.Size(696, 175);
            this.txtMensagemSOAP.TabIndex = 0;
            this.txtMensagemSOAP.Text = resources.GetString("txtMensagemSOAP.Text");
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(495, 482);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(213, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar Requisição SOAP";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtMensagemSOAPRecebida
            // 
            this.txtMensagemSOAPRecebida.Location = new System.Drawing.Point(12, 244);
            this.txtMensagemSOAPRecebida.Multiline = true;
            this.txtMensagemSOAPRecebida.Name = "txtMensagemSOAPRecebida";
            this.txtMensagemSOAPRecebida.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMensagemSOAPRecebida.Size = new System.Drawing.Size(696, 156);
            this.txtMensagemSOAPRecebida.TabIndex = 3;
            this.txtMensagemSOAPRecebida.TextChanged += new System.EventHandler(this.txtMensagemSOAPRecebida_TextChanged);
            // 
            // lblMensagemSoap
            // 
            this.lblMensagemSoap.AutoSize = true;
            this.lblMensagemSoap.Location = new System.Drawing.Point(13, 12);
            this.lblMensagemSoap.Name = "lblMensagemSoap";
            this.lblMensagemSoap.Size = new System.Drawing.Size(213, 17);
            this.lblMensagemSoap.TabIndex = 4;
            this.lblMensagemSoap.Text = "Mensagem SOAP a ser enviada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mensagem SOAP retornada:";
            // 
            // gbTipoRequisicao
            // 
            this.gbTipoRequisicao.Controls.Add(this.rbServico);
            this.gbTipoRequisicao.Controls.Add(this.rbComponente);
            this.gbTipoRequisicao.Location = new System.Drawing.Point(16, 406);
            this.gbTipoRequisicao.Name = "gbTipoRequisicao";
            this.gbTipoRequisicao.Size = new System.Drawing.Size(693, 70);
            this.gbTipoRequisicao.TabIndex = 6;
            this.gbTipoRequisicao.TabStop = false;
            this.gbTipoRequisicao.Text = "Tipo de requisição";
            // 
            // rbServico
            // 
            this.rbServico.AutoSize = true;
            this.rbServico.Location = new System.Drawing.Point(373, 28);
            this.rbServico.Name = "rbServico";
            this.rbServico.Size = new System.Drawing.Size(194, 21);
            this.rbServico.TabIndex = 1;
            this.rbServico.TabStop = true;
            this.rbServico.Text = "Chamada via serviço WCF";
            this.rbServico.UseVisualStyleBackColor = true;
            // 
            // rbComponente
            // 
            this.rbComponente.AutoSize = true;
            this.rbComponente.Checked = true;
            this.rbComponente.Location = new System.Drawing.Point(58, 28);
            this.rbComponente.Name = "rbComponente";
            this.rbComponente.Size = new System.Drawing.Size(233, 21);
            this.rbComponente.TabIndex = 0;
            this.rbComponente.TabStop = true;
            this.rbComponente.Text = "Chamada direta via componente";
            this.rbComponente.UseVisualStyleBackColor = true;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(16, 504);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 17);
            this.lblErro.TabIndex = 7;
            // 
            // txtEnderecoHTTP
            // 
            this.txtEnderecoHTTP.Location = new System.Drawing.Point(755, 35);
            this.txtEnderecoHTTP.Name = "txtEnderecoHTTP";
            this.txtEnderecoHTTP.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEnderecoHTTP.Size = new System.Drawing.Size(697, 22);
            this.txtEnderecoHTTP.TabIndex = 8;
            this.txtEnderecoHTTP.Text = "https://app.viafacil.com.br/vpnew/imprimirValePedagioSTP.do";
            // 
            // lblEnderecoHttp
            // 
            this.lblEnderecoHttp.AutoSize = true;
            this.lblEnderecoHttp.Location = new System.Drawing.Point(755, 15);
            this.lblEnderecoHttp.Name = "lblEnderecoHttp";
            this.lblEnderecoHttp.Size = new System.Drawing.Size(110, 17);
            this.lblEnderecoHttp.TabIndex = 9;
            this.lblEnderecoHttp.Text = "Endereço HTTP";
            this.lblEnderecoHttp.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtParametrosPostHttp
            // 
            this.txtParametrosPostHttp.Location = new System.Drawing.Point(755, 89);
            this.txtParametrosPostHttp.Multiline = true;
            this.txtParametrosPostHttp.Name = "txtParametrosPostHttp";
            this.txtParametrosPostHttp.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtParametrosPostHttp.Size = new System.Drawing.Size(696, 156);
            this.txtParametrosPostHttp.TabIndex = 10;
            this.txtParametrosPostHttp.Text = "sessao=96110259068216570&viagem=123&imprimirObservacoes=true";
            // 
            // lblParametrosPostHttp
            // 
            this.lblParametrosPostHttp.AutoSize = true;
            this.lblParametrosPostHttp.Location = new System.Drawing.Point(755, 69);
            this.lblParametrosPostHttp.Name = "lblParametrosPostHttp";
            this.lblParametrosPostHttp.Size = new System.Drawing.Size(164, 17);
            this.lblParametrosPostHttp.TabIndex = 11;
            this.lblParametrosPostHttp.Text = "Parametros POST HTTP";
            this.lblParametrosPostHttp.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // btnEnviarPostHttp
            // 
            this.btnEnviarPostHttp.Location = new System.Drawing.Point(1229, 453);
            this.btnEnviarPostHttp.Name = "btnEnviarPostHttp";
            this.btnEnviarPostHttp.Size = new System.Drawing.Size(222, 23);
            this.btnEnviarPostHttp.TabIndex = 12;
            this.btnEnviarPostHttp.Text = "Enviar Requisição Http";
            this.btnEnviarPostHttp.UseVisualStyleBackColor = true;
            this.btnEnviarPostHttp.Click += new System.EventHandler(this.btnEnviarPostHttp_Click);
            // 
            // txtRetornoHTTP
            // 
            this.txtRetornoHTTP.Location = new System.Drawing.Point(755, 289);
            this.txtRetornoHTTP.Multiline = true;
            this.txtRetornoHTTP.Name = "txtRetornoHTTP";
            this.txtRetornoHTTP.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRetornoHTTP.Size = new System.Drawing.Size(696, 156);
            this.txtRetornoHTTP.TabIndex = 13;
            // 
            // lblRetornoHTTP
            // 
            this.lblRetornoHTTP.AutoSize = true;
            this.lblRetornoHTTP.Location = new System.Drawing.Point(755, 259);
            this.lblRetornoHTTP.Name = "lblRetornoHTTP";
            this.lblRetornoHTTP.Size = new System.Drawing.Size(100, 17);
            this.lblRetornoHTTP.TabIndex = 14;
            this.lblRetornoHTTP.Text = "Retorno HTTP";
            // 
            // lblErro2
            // 
            this.lblErro2.AutoSize = true;
            this.lblErro2.ForeColor = System.Drawing.Color.Red;
            this.lblErro2.Location = new System.Drawing.Point(770, 487);
            this.lblErro2.Name = "lblErro2";
            this.lblErro2.Size = new System.Drawing.Size(0, 17);
            this.lblErro2.TabIndex = 15;
            // 
            // AplicacaoDeTestesServicoViaFacil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 526);
            this.Controls.Add(this.lblErro2);
            this.Controls.Add(this.lblRetornoHTTP);
            this.Controls.Add(this.txtRetornoHTTP);
            this.Controls.Add(this.btnEnviarPostHttp);
            this.Controls.Add(this.lblParametrosPostHttp);
            this.Controls.Add(this.txtParametrosPostHttp);
            this.Controls.Add(this.lblEnderecoHttp);
            this.Controls.Add(this.txtEnderecoHTTP);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.gbTipoRequisicao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensagemSoap);
            this.Controls.Add(this.txtMensagemSOAPRecebida);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensagemSOAP);
            this.Name = "AplicacaoDeTestesServicoViaFacil";
            this.Text = "Aplicação de Testes Serviço Via Fácil";
            this.Load += new System.EventHandler(this.AplicacaoDeTestesServicoViaFacil_Load);
            this.gbTipoRequisicao.ResumeLayout(false);
            this.gbTipoRequisicao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensagemSOAP;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtMensagemSOAPRecebida;
        private System.Windows.Forms.Label lblMensagemSoap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTipoRequisicao;
        private System.Windows.Forms.RadioButton rbServico;
        private System.Windows.Forms.RadioButton rbComponente;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.TextBox txtEnderecoHTTP;
        private System.Windows.Forms.Label lblEnderecoHttp;
        private System.Windows.Forms.TextBox txtParametrosPostHttp;
        private System.Windows.Forms.Label lblParametrosPostHttp;
        private System.Windows.Forms.Button btnEnviarPostHttp;
        private System.Windows.Forms.TextBox txtRetornoHTTP;
        private System.Windows.Forms.Label lblRetornoHTTP;
        private System.Windows.Forms.Label lblErro2;
    }
}

