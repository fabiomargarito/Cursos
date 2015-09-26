using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JBSMedical.CadastrosBoundedContext.Aplicacacao.Servicos;
using JBSMedical.CadastrosBoundedContext.Apresentacao.DTOS;
using JBSMedical.CadastrosBoundedContext.Infraestrutura.Repositorios;

namespace SistemaJBSMedical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Gravar_Click(object sender, EventArgs e)
        {
            ServicoDeGravacaoDePaciente servicoDeGravacaoDePaciente = new ServicoDeGravacaoDePaciente(new DalPacienteFake());
            servicoDeGravacaoDePaciente.GravarPaciente(new DTOPaciente(CampoCPF.Text, CampoNome.Text));
        }
    }
}
