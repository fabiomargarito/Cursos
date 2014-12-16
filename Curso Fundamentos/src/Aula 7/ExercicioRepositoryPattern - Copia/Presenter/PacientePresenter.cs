using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBCorpHealth.Aplicacao.Servico;
using MBCorpHealth.Dominio.Contratos;
using MBCorpHealth.Infraestrutura.Repositorio;
using MBCorpHealth.View;
using Microsoft.Practices.Unity;
using NHibernate;

namespace MBCorpHealth.Presenter
{
    public class PacientePresenter
    {
        private readonly IPacienteView _pacienteView;
        private readonly UnityContainer _unityContainer;
        
        public PacientePresenter(IPacienteView pacienteView)
        {
            _unityContainer = new UnityContainer();
            _unityContainer.RegisterType<IRepositorioPaciente, RepositorioPaciente>();
            _unityContainer.RegisterInstance<ISession>(ConfiguracaoNHibernate.Criar().OpenSession());
            
            _pacienteView = pacienteView;
            _pacienteView.Gravar += _pacienteView_Gravar;



            ServicoDePaciente servicoDePaciente = _unityContainer.Resolve<ServicoDePaciente>();
            _pacienteView.ListarPacientes(servicoDePaciente.ListarPorTrecho(""));

        }

        void _pacienteView_Gravar(View.ViewModel.PacienteViewModel pacienteViewModel)
        {
            ServicoDePaciente servicoDePaciente = _unityContainer.Resolve<ServicoDePaciente>();
            servicoDePaciente.Gravar(pacienteViewModel);
            _pacienteView.ListarPacientes(servicoDePaciente.ListarPorTrecho(""));
        }
    }
}
