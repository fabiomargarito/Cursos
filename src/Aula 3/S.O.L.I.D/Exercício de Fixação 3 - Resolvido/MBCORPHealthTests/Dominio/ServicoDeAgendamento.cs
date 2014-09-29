using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBCORPHealthTests.Dominio
{
    class ServicoDeAgendamento
    {
        public void CriarAgendamento(Agendamento agendamento)
        {
            if (agendamento.Exames.Count == 0)
            {
                throw new Exception("Nâo posso criar agendamento com 0 exames");
            }

            IRepositorio repositorio = new RepositorioAgendamento();
            repositorio.Gravar(agendamento);
        }
    }
}
