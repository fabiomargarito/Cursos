using System;
using JBSMedical;

namespace SistemaJBSHealth
{
    public class FabricaDeAgendamento
    {
        private Agendamento _Agendamento;

        public FabricaDeAgendamento()
        {
            _Agendamento = new Agendamento();
        }

        public FabricaDeAgendamento InformarMedico(string crm, string nome)
        {
            _Agendamento.InformarMedico(new Medico (crm,nome));
            return this;
        }

        public FabricaDeAgendamento InformarPaciente(string cpf, string Nome)
        {
            _Agendamento.InformarPaciente(new Paciente(cpf, Nome));
            return this;
        }

        public FabricaDeAgendamento InformarExame(string codigo, string descricao, double preco)
        {

            TipoExame tipoExame = new TipoExame(codigo, descricao);
            Exame exame = new Exame(Guid.NewGuid(), tipoExame, preco);
            _Agendamento.AdicionarExame(exame);

            return this;
        }

        public Agendamento Criar()
        {
            return _Agendamento;
        }

    }
}