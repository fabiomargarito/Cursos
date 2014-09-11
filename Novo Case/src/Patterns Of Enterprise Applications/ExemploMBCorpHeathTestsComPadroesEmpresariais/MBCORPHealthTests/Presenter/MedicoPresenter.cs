using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBCORPHealthTests.Dominio.Servico;
using MBCORPHealthTests.View;
using TestesUnitarios;

namespace MBCORPHealthTests.Presenter
{
    public class MedicoPresenter
    {
        private readonly IMedicoView _iMedicoView;

        public MedicoPresenter(IMedicoView iMedicoView)
        {
            _iMedicoView = iMedicoView;
            _iMedicoView.Gravar += _iMedicoView_Gravar;
            _iMedicoView.Excluir += _iMedicoView_Excluir;
        }

        void _iMedicoView_Excluir(MedicoDto obj)
        {
            throw new NotImplementedException();
        }

        void _iMedicoView_Gravar(MedicoDto obj)
        {
            var servicoPersistenciaMedico = new ServicoPersistenciaMedico(new RepositorioMedicoNHibernate());
            servicoPersistenciaMedico.Gravar(obj);
            var medicoDtos = servicoPersistenciaMedico.ListarTodos().Select(medico => new MedicoDto { CRM = medico.CRM, NOME = medico.Nome }).ToList();
            _iMedicoView.ListarMedicos(medicoDtos);
        }

        public void RetornarMedicos()
        {
            var servicoPersistenciaMedico = new ServicoPersistenciaMedico(new RepositorioMedicoNHibernate());            
            var medicoDtos = servicoPersistenciaMedico.ListarTodos().Select(medico => new MedicoDto {CRM = medico.CRM, NOME = medico.Nome}).ToList();

            _iMedicoView.ListarMedicos(medicoDtos);
        }

    }
}
