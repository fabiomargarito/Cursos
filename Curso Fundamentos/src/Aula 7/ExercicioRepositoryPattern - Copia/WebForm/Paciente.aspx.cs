using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MBCorpHealth.Presenter;
using MBCorpHealth.View;
using MBCorpHealth.View.ViewModel;

namespace WebForm
{
    public partial class Paciente : System.Web.UI.Page, IPacienteView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PacientePresenter pacientePresenter = new PacientePresenter(this);
        }

        public event Action<PacienteViewModel> Gravar;
       

        public void ListarPacientes(List<PacienteViewModel> list)
        {
            GridDePacientes.DataSource = list;
            GridDePacientes.DataBind();
        }

        protected void Gravar_Click(object sender, EventArgs e)
        {
            Gravar(new PacienteViewModel{Cpf = CPF.Text,Nome = Nome.Text});
        }
    }
}