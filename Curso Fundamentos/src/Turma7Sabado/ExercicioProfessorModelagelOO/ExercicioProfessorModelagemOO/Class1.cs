using System;
using System.Collections.Generic;

namespace ExercicioProfessorModelagemOO
{


    public class Pessoa
    {
        public Pessoa(string nome, string cPf)
        {           
            Nome = nome;
            CPf = cPf;

            ValidarDados();
        }


        public virtual void  ValidarDados()
        {
            if (string.IsNullOrWhiteSpace(this.CPf)) throw new ArgumentNullException("Nome não pode ser nulo ou branco!");
            if (string.IsNullOrWhiteSpace(this.Nome)) throw new ArgumentNullException("Nome não pode ser nulo ou branco!");
        }

        public string Nome { get; protected set; }
        public string CPf { get; protected set; }
    }

    public class Atendente:Pessoa
    {

        public Atendente(string nome, string cPf) : base(nome, cPf)
        {
        }

        public Endereco Endereco { get; private set; }

        public void DefinirEndereco(Endereco endereco)
        {
            if (endereco == null) throw new ArgumentNullException("Endereço não pode ser nulo!");

            Endereco = endereco;
        }

        

    }

    public class Paciente:Pessoa
    {
        public Paciente(string nome, string cPf) : base(nome, cPf)
        {
        }
    }

    public class Medico:Pessoa
    {
        public Medico(string nome, string cPf) : base(nome, cPf)
        {
        }

        public override void ValidarDados()
        {
            base.ValidarDados();
            if(string.IsNullOrWhiteSpace(CRM)) throw  new ArgumentNullException("CRM não pode ser nulo ou branco!");

        }

        public void ValidarCrm()
        {            
        }

        public string CRM { get; private set; }
        
    }

    public class MedicoLaudo:Medico
    {
        public MedicoLaudo(string nome, string cPf) : base(nome, cPf)
        {
        }
    }


    public class Endereco
    {

        public Endereco(string logradouro, string cep)
        {
           
           ValidarIntegridadeDosDados(logradouro,cep);

           Logradouro = logradouro;
           CEP = cep;
        }

        private void ValidarIntegridadeDosDados(string logradouro, string cep)
        {
            if (string.IsNullOrWhiteSpace(logradouro)) throw new ArgumentNullException("Logradoutro inválido");
            if (string.IsNullOrWhiteSpace(cep)) throw new ArgumentNullException("CEP inválido");            
        }
       
        public string Logradouro { get; }
        public string CEP { get; }



    }


    public abstract class ServicoDeConsultaDeEndereco
    {
        public abstract Endereco ConsultarEndereco(string cep);
    }

    public class ServicoDeConsultaDeEnderecoNosCorreios : ServicoDeConsultaDeEndereco
    {
        public override Endereco ConsultarEndereco(string cep)
        {
            // Realiza uma requisição no site dos correios
            return new Endereco("logradouro", "cep");
        }
    }


    public class ServicoDeConsultaDeEnderecoNoCorparativo:ServicoDeConsultaDeEndereco
    {
        public override Endereco ConsultarEndereco(string cep)
        {
            //REaliza a consulta no serviço interno 
            return new Endereco("logradouro", "cep");
        }
    }

    public class ServicoDeConsultaDeEnderecoNoCorparativoV2 : ServicoDeConsultaDeEndereco
    {
        public override Endereco ConsultarEndereco(string cep)
        {
            //REaliza a consulta no serviço interno V2 
            return new Endereco("logradouro", "cep");
        }
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


    public interface IServicoDeConsultaDeEndereco
    {
        Endereco ConsultarEndereco(string cep);
        

    }

    public interface IServicoDeConsultaDeEnderecoCorporativo
    {
        Endereco ConsultarEndereco2(string cep);
     

    }

    public class Consultar:IServicoDeConsultaDeEndereco
    {
        public Endereco ConsultarEndereco(string cep)
        {
            return new Endereco("fabio", "34343");
        }
    }
}


