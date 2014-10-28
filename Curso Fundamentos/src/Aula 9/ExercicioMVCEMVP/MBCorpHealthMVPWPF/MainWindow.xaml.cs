using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MBCorpHealth.Presenter;
using MBCorpHealth.View;
using MBCorpHealth.View.ViewModel;

namespace MBCorpHealthMVPWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IListagemCartaoView
    {
        public MainWindow()
        {
            InitializeComponent();
            CartaoPresenter cartaoPresenter = new CartaoPresenter(null,this);
            cartaoPresenter.ListarCartoes();
        }

        public void ExibirCartoes(IList<CartaoViewModel> cartoes)
        {
            grid.ItemsSource = cartoes;            
        }
    }
}
