using System;

namespace MBCorpHealth.Dominio
{
    public class Resultado
    {

        public DateTime Data { get; private set; }
        public string Descricao { get; private set; }
        public Medico MedicoResponsavel { get; private set; }


        public Resultado(Medico medicoResponsavel, DateTime data, string descricao)
        {
            ValidarDadosParaCriacaoDoResultado(medicoResponsavel,data,descricao);
            MedicoResponsavel = medicoResponsavel;
            Data = data;
            Descricao = descricao;
        }


        private void ValidarDadosParaCriacaoDoResultado(Medico medicoResponsavel, DateTime data, string descricao)
        {
            if (medicoResponsavel == null) throw new ArgumentNullException("O médico responsável deve ser informado!");
            if (string.IsNullOrEmpty(descricao )) throw new ArgumentNullException("A descrição do resultado do exame deve ser informada!");
            if (data > DateTime.MinValue) throw new ArgumentException("É necessário informar uma data válida para o resultado!");
        }
    }
}