using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JBSHealthCare.Aplicacao.Servico;
using JBSHealthCare.Aplicacao.Servico.BoundedContextGestaoDeAgendamentos;
using JBSHealthCare.Infraestrutura.Repositorio;
using JBSHealthCare.Infraestrutura.Repositorio.BoundedContextGestaoDeAgendamentos;
using JBSHealthCare.View.ViewModels;
using JBSHealthCare.View.ViewModels.BoundedContextGestaoDeAgendamentos;

namespace WindowsJBSHealthCare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServicoDeAgendamento servicoDeAgendamento = new ServicoDeAgendamento(new Agendamentos());
            servicoDeAgendamento.CriarAgendamento(new AgendamentoViewModel
            {
                cpf = cpf.Text,
                crm = crm.Text,
                numeroCID = cid.Text
            });

            MessageBox.Show("Gravado com sucesso!!!!");
        }
    }
}
