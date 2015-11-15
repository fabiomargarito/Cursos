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
            this.txtMensagemSOAP = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtMensagemSOAPRecebida = new System.Windows.Forms.TextBox();
            this.lblMensagemSoap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTipoRequisicao = new System.Windows.Forms.GroupBox();
            this.rbServico = new System.Windows.Forms.RadioButton();
            this.rbComponente = new System.Windows.Forms.RadioButton();
            this.lblErro = new System.Windows.Forms.Label();
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
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(633, 482);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
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
            // AplicacaoDeTestesServicoViaFacil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 526);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.gbTipoRequisicao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensagemSoap);
            this.Controls.Add(this.txtMensagemSOAPRecebida);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensagemSOAP);
            this.Name = "AplicacaoDeTestesServicoViaFacil";
            this.Text = "Aplicação de Testes Serviço Via Fácil";
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
    }
}

