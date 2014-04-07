using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Practices.Unity;
namespace SistemaDeGestaoDeAcoesMVP
{
    public partial class ListaAcoes : System.Web.UI.Page,Domain.IAcaoView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<Infraestrutura.IRepositorio<Domain.Acao>, Infraestrutura.RepositorioAcaoFake>();
            unityContainer.RegisterInstance<Domain.IAcaoView>(this);
            
            
            
            Domain.AcaoPresenter acaoPresenter = unityContainer.Resolve<Domain.AcaoPresenter>();
            acaoPresenter.retornarAcoes();

            GridView1.DataSource = acoes;
            GridView1.DataBind();
        }

        public List<Domain.Acao> acoes { get; set; }
   
    }
}