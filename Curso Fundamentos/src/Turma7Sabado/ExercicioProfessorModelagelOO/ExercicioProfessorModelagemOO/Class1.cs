using System;
using System.Collections.Generic;

namespace ExercicioProfessorModelagemOO
{

    public class Atendente
    {
        public Atendente(string nome, string cpf)
        {
            Nome = nome;
            CPf = cpf;
        }

        public string Nome { get; }
        public string CPf { get; }

        public Endereco Endereco { get; private set; }

        public void DefinirEndereco(Endereco endereco)
        {
            if (endereco == null) throw new ArgumentNullException(nameof(endereco));

            Endereco = endereco;
        }


    }

    public class Endereco
    {
        public Endereco(string logradouro, string cep)
        {
            if (string.IsNullOrWhiteSpace(logradouro)) throw new ArgumentNullException("Logradoutro inválido");
            if (string.IsNullOrWhiteSpace(cep)) throw new ArgumentNullException("CEP inválido");

            Logradouro = logradouro;
            CEP = cep;
        }

        public string Logradouro { get; }
        public string CEP { get; }
    }


    public class Paciente
    {
        public string Nome { get; }
        public string CPf { get; }
    }

    public class Medico
    {
        public string Nome { get; }
        public string CPf { get; }
    }


    public class PlanoDeSaude
    {
    }

    public class Agendamento
    {
        public Agendamento()
        {
            Exames = new List<Exame>();
        }

        public int Codigo { get; private set; }
        public Medico Medico { get; private set; }
        public Paciente Paciente { get; private set; }
        public Atendente Atendente { get; private set; }
        private IEnumerable<Exame> Exames { get; }


        public void InformarMedico(Medico medico)
        {
            if (medico == null) throw new ArgumentNullException(nameof(medico));

            Medico = medico;
        }


        public void InformarPaciente(Paciente paciente)
        {
            if (paciente == null) throw new ArgumentNullException(nameof(paciente));
            Paciente = paciente;
        }


        public void InformarAtendente(Atendente atendente)
        {
            if (atendente == null) throw new ArgumentNullException(nameof(atendente));

            Atendente = atendente;
        }

        public void AdicionarExame(Exame exame)
        {
            if (exame == null) throw new ArgumentNullException(nameof(exame));
            (Exames as IList<Exame>).Add(exame);
        }

        public Agendamento AgendarExame(Atendente atendente, Paciente paciente, Medico medico, IList<Exame> exames)
        {
            InformarAtendente(atendente);
            InformarMedico(medico);
            InformarPaciente(paciente);
            foreach (var exame in exames)
            {
                ((List<Exame>)Exames).Add(exame);
            }

            return this;
        }
    }


    public class Exame
    {
        public TipoExame TipoExame { get; private set; }

    }

    public class TipoExame
    {
        
        /// <summary>
        /// Classificação Brasileira Hierrquizada de Procedimentos Médicos 
        /// </summary>
        public string CBHPM { get; private set; }

        public string Descrição { get; private set; }
    }


    public class ResultadoExame
    {
    }

}


