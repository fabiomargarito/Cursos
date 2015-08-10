using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MBCorpHealth.Presenter;
using MBCorpHealth.View;
using MBCorpHealth.View.ViewModel;

namespace MBCorpHealTestMVPWeb
{
    public partial class ListagemDeCartoes2 : System.Web.UI.Page,IListagemCartaoView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CartaoPresenter cartaoPresenter = new CartaoPresenter(null,this);
            cartaoPresenter.ListarCartoes();
        }

        public void ExibirCartoes(IList<CartaoViewModel> cartoes)
        {
            GridView1.DataSource = cartoes;
            GridView1.DataBind();
        }
    }
}