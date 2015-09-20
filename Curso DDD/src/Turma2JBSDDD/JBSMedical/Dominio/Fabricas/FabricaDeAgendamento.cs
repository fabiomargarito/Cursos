using System;
using JBSMedical.Dominio.Entidades;

namespace JBSMedical.Dominio.Fabricas
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
            PlanoDeSaude planoDeSaude = new PlanoDeSaude();
            planoDeSaude.CNPJ = "123456";
            planoDeSaude.RazaoSocial = "AAAA";
            Paciente paciente = new Paciente(cpf, Nome);
            paciente.InformarPlanoDeSaude(planoDeSaude);

            _Agendamento.InformarPaciente(paciente);
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