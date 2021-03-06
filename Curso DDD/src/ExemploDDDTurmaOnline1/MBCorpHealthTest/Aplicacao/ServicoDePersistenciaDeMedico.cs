﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Contratos;
using MBCorpHealthTest.Dominio.ContextoCadastrosCorporativos.Entidades;
using MBCorpHealthTest.ViewModel;
using NHibernate;

namespace MBCorpHealthTest.Aplicacao
{
    public class ServicoDePersistenciaDeMedico
    {
        public MedicoViewModel PesquisarMedicoPorCRMEEstado(MedicoViewModel medicoViewModel, ISession session,IMedicos medicos)
        {
                                        
                Medico medico = medicos.PesquisarMedicoPorCRMEEstado(medicoViewModel.CRM, medicoViewModel.Estado);

                return new MedicoViewModel {CRM = medico.CRM, Estado = medico.Estado, Nome = medico.Nome};    

        }

    }
}
