namespace SistemaJBSMedical
{
    partial class Form1
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
            this.CampoCPF = new System.Windows.Forms.TextBox();
            this.CampoNome = new System.Windows.Forms.TextBox();
            this.Gravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CampoCPF
            // 
            this.CampoCPF.Location = new System.Drawing.Point(43, 44);
            this.CampoCPF.Name = "CampoCPF";
            this.CampoCPF.Size = new System.Drawing.Size(100, 22);
            this.CampoCPF.TabIndex = 0;
            // 
            // CampoNome
            // 
            this.CampoNome.Location = new System.Drawing.Point(43, 94);
            this.CampoNome.Name = "CampoNome";
            this.CampoNome.Size = new System.Drawing.Size(527, 22);
            this.CampoNome.TabIndex = 1;
            // 
            // Gravar
            // 
            this.Gravar.Location = new System.Drawing.Point(43, 136);
            this.Gravar.Name = "Gravar";
            this.Gravar.Size = new System.Drawing.Size(155, 23);
            this.Gravar.TabIndex = 2;
            this.Gravar.Text = "Gravar";
            this.Gravar.UseVisualStyleBackColor = true;
            this.Gravar.Click += new System.EventHandler(this.Gravar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 399);
            this.Controls.Add(this.Gravar);
            this.Controls.Add(this.CampoNome);
            this.Controls.Add(this.CampoCPF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CampoCPF;
        private System.Windows.Forms.TextBox CampoNome;
        private System.Windows.Forms.Button Gravar;
    }
}

