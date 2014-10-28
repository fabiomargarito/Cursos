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
    public partial class Criar : System.Web.UI.Page, IGravacaoCartao
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cartaoPresenter = new CartaoPresenter(this, null);
            
        }

        public event Action<CartaoViewModel> Gravar;

        protected void Button1_Click(object sender, EventArgs e)
        {
            Gravar(new CartaoViewModel{CodigoDeSeguranca = TextBox1.Text,NomeConformeEscritoNoCartao = TextBox2.Text,NumeroDoCartao = TextBox3.Text});
        }
    }
}