using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using UI.Presenter;
using UI.View;
using UI.View.ViewModel;

namespace SistemaDeGEstaoDeAcoesWPFMVP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IAcaoView
    {
        public MainWindow()
        {
            InitializeComponent();

            AcaoPresenter acaoPresenter = new AcaoPresenter(this);
            acaoPresenter.RetornarAcoes();
        }

        public void ListarAcoes(IList acoes)
        {
            throw new NotImplementedException();
        }

        public void ListarAcoes(IList<AcaoViewModel> acoes)
        {
            DataGridAcoes.ItemsSource = acoes;
            
        }


        public event Action<AcaoViewModel> Excluir;

        protected virtual void OnExcluir(AcaoViewModel obj)
        {
            Action<AcaoViewModel> handler = Excluir;
            if (handler != null) handler(obj);
        }


        public event Action<AcaoViewModel> Gravar;

        protected virtual void OnGravar(AcaoViewModel obj)
        {
            Action<AcaoViewModel> handler = Gravar;
            if (handler != null) handler(obj);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OnGravar(new AcaoViewModel { Codigo = NomeAcao.Text });
        }
    }
}
