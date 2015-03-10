using System;
using MBCorpHealthTest.Dominio.Entidades;

namespace MBCorpHealthTest.Dominio.Fabricas
{
    public class FabricaDeAgendamento
    {
        private Medico _medico;
        private Atendente _atendente;

        public  FabricaDeAgendamento InformarMedico(string crm,string nome)
        {
            _medico = new Medico(crm,nome);
            return this;
        }
        public  FabricaDeAgendamento InformarAtendente(string cpf, string nome)
        {
            _atendente = new Atendente(cpf,nome);
            return this;
        }

        public  Agendamento Criar()
        {
            if (_medico == null)
                new Exception("Médico não informado!");
            
            if (_atendente == null)
                new Exception("Atendente não informado!");

            return  new Agendamento(_atendente,_medico);
        }
    }
}