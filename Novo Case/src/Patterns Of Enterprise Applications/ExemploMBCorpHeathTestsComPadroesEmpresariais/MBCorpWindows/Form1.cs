using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MBCORPHealthTests.Presenter;
using MBCORPHealthTests.View;

namespace MBCorpWindows
{
    public partial class Form1 : Form,IMedicoView
    {
        private MedicoPresenter medicoPresenter;
        
        public Form1()
        {
            InitializeComponent();
            medicoPresenter = new MedicoPresenter(this);
            medicoPresenter.RetornarMedicos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ListarMedicos(IList<MedicoDto> medicos)
        {                       
            dataGridView1.DataSource = medicos;            
        }

        public event Action<MedicoDto> Gravar;
        public event Action<MedicoDto> Excluir;

        private void button1_Click(object sender, EventArgs e)
        {
            var medicoDto = new MedicoDto();
            medicoDto.CRM = textBox1.Text;
            medicoDto.NOME = textBox2.Text;

            Gravar(medicoDto);
        }
    }
}
