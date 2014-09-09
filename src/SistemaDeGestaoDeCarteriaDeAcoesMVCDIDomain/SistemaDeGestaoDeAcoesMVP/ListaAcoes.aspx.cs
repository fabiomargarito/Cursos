using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Domain;
using Microsoft.Practices.Unity;
using UI.Presenter;
using UI.View;
using UI.View.ViewModel;

namespace SistemaDeGestaoDeAcoesMVP
{
    public partial class ListaAcoes : System.Web.UI.Page,IAcaoView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IUnityContainer unityContainer = new UnityContainer();                      
            unityContainer.RegisterInstance<IAcaoView>(this);
                                    
            AcaoPresenter acaoPresenter = unityContainer.Resolve<AcaoPresenter>();
            
            
            acaoPresenter.RetornarAcoes();

          
        }

        public void ListarAcoes(IList<AcaoViewModel> acoes)
        {
            GridView1.DataSource = acoes;
            GridView1.DataBind();
        }

        public event Action<AcaoViewModel> Gravar;
        public event Action<AcaoViewModel> Excluir;

        protected void BtnGravar_Click(object sender, EventArgs e)
        {
            Gravar(new AcaoViewModel { Codigo = TextBox1.Text, Empresa = new EmpresaViewModel() { CNPJEmpresa = "123" } });

        }
    }
}