using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MBCorpHealthTestTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComoAtendenteQueroRealizarCadastrarUmAgendamento()
        {
            //Arrage
            Agendamento agendamento = new Agendamento(new Paciente("2345345335", "Fabio Margarito","fabio@fabio.com.br"), new Medico("234", "SP", "Mario Peres"), new Atendente("23434343", "Veranildo"));
            agendamento.AdicionarExame(new Exame(new TipoExame("10101012", "Hemograma", 100)));
            
            //Act
            ServicoDeAgendamento servicoDeAgendamento = new ServicoDeAgendamento(new ServicoDeEnvioEmailCorporativo());
            var retornoAgendamento = servicoDeAgendamento.CadastrarAgendamento(agendamento);

            

            //Assert
            Assert.IsTrue(retornoAgendamento.ID != 0);
            Assert.IsTrue(retornoAgendamento.Exames.Count >0);

        }
        
        [TestMethod]
        public void ComoAtendenteQueroPesquisarUmPacientePorNome()
        {
        }

        [TestMethod]
        public void ComoAtendenteQuandoOPacienteNaoExistirQueroCadastrar()
        {
        }

        [TestMethod]
        public void ComoAtendenteQueroPesquisarUmPacientePorCPF()
        {
        }

        [TestMethod]
        public void ComoAtendenteQueroVerificarSeOPlanoDeSaudeCobreOExame()
        {
            //arrange
            IServicoDeValidacaoDeCoberturaDeExame servicoDeValidacaoDeCoberturaDeExame = new ServicoDeValidacaoDeCoberturaDeExame();
            
            //act,assert
           Assert.IsTrue(servicoDeValidacaoDeCoberturaDeExame.VerificarCoberturaDoExame(new TipoExame("10101212","teste",100),new Paciente("1234","Fabio","fabio@fabio.com.br")));
        }


        [TestMethod]
        public void ComoAtendenteQueroVerificarOValorTotalDoAgendamento()
        {
            //Arrage
            Agendamento agendamento = new Agendamento(new Paciente("2345345335", "Fabio Margarito", "fabio@fabio.com.br"), new Medico("234", "SP", "Mario Peres"), new Atendente("23434343", "Veranildo"));
            agendamento.AdicionarExame(new Exame(new TipoExame("10101012", "Hemograma", 100)));

            //Act
            ServicoDeAgendamento servicoDeAgendamento = new ServicoDeAgendamento(new ServicoDeEnvioEmailCorporativo());
            var retornoAgendamento = servicoDeAgendamento.CadastrarAgendamento(agendamento);
            

            //Assert
            Assert.IsTrue(agendamento.CalcularValorTotal()==100);

        }

        [TestMethod]
        public void ComoAtendenteQueroConsultarUmMedicoPorCRMEEstado()
        {
        }

        [TestMethod]
        public void ComoAtendenteQueroConsultarAAgendaDasUnidadesDeDiagnosticoPorTipoDeExame()
        {
        }

        [TestMethod]
        public void ComoMedicoDeDiagnosticoQueroEmitirUmLaudoParaUmExame()
        {
            //Arrage
            Agendamento agendamento = new Agendamento(new Paciente("2345345335", "Fabio Margarito", "fabio@fabio.com.br"), new Medico("234", "SP", "Mario Peres"), new Atendente("23434343", "Veranildo"));
            agendamento.AdicionarExame(new Exame(new TipoExame("10101012", "Hemograma", 100)));

            //Act
            ServicoDeAgendamento servicoDeAgendamento = new ServicoDeAgendamento(new ServicoDeEnvioEmailCorporativo());
            var retornoAgendamento = servicoDeAgendamento.CadastrarAgendamento(agendamento);

            agendamento.Exames.FirstOrDefault().EmitirLaudo(new Laudo("bla bla bla bla"));

            //Assert
            Assert.IsTrue(agendamento.Exames.FirstOrDefault().Laudo.Descricao == "bla bla bla bla");
            
        }

        [TestMethod]
        public void
            ComoAtendenteAoFinalizarCadastroDeAgendamentoQueroGerarCredencialDeAcessoEEnviarEmailComOsDadosDoAgendamento
            ()
        {
        }

        [TestMethod]
        public void ComoPacienteQueroConsultarOResultadoDosMeusExames()
        {
        }

        [TestMethod]
        public void ComoAtendenteQueroSolicitarEmissaoDeFAturaParaUmAgendamento()
        {            
        }
    }

    public class ServicoDeAgendamento
    {
        private readonly IServicoDeEnvioEmail _servicoDeEnvioEmail;

        public ServicoDeAgendamento(IServicoDeEnvioEmail servicoDeEnvioEmail)
        {
            _servicoDeEnvioEmail = servicoDeEnvioEmail;
        }

        public Agendamento CadastrarAgendamento(Agendamento agendamento)
        {
            //Persistir na Base

            //Enviar Email
            _servicoDeEnvioEmail.Enviar("mbcorp@mbcorp.com.br",agendamento.Paciente.Email,"Agendamento Confirmado","Mensagem para o paciente");

            return agendamento;
        }
    }

    public interface IServicoDeEnvioEmail
    {
        void Enviar(string de, string para, string asssunto, string mensagem);
    }

    public class ServicoDeEnvioEmailCorporativo:IServicoDeEnvioEmail
    {
        public void Enviar(string de, string para, string asssunto, string mensagem)
        {
            
        }
    }

    public interface IServicoDeValidacaoDeCoberturaDeExame
    {
        bool VerificarCoberturaDoExame(TipoExame tipoExame, Paciente paciente);
    }

    public class ServicoDeValidacaoDeCoberturaDeExame:IServicoDeValidacaoDeCoberturaDeExame
    {
        public bool VerificarCoberturaDoExame(TipoExame tipoExame, Paciente paciente)
        {
            return true;
        }
    }


    public class Agendamento
    {
        public ISet<Exame> Exames { get; set; }
        public int ID { get; set; }
        public Atendente Atendente { get; private set; }
        public Paciente Paciente { get; private set; }
        public Medico MedicoSolicitante { get; private set; }

       
        public Agendamento(Paciente paciente, Medico medicoSolicitante, Atendente atendente)
        {
            Paciente = paciente;
            Atendente = atendente;
            MedicoSolicitante = medicoSolicitante;

            ID = int.MaxValue;

        }
        public void AdicionarExame(Exame tipoExame)
        {
            Exames = new HashSet<Exame>();
            Exames.Add(tipoExame);

        }


        public Double CalcularValorTotal()
        {
            Double valorTotal = Exames.Sum(exame => exame.TipoExame.Valor);
            return valorTotal;
        }
    }

    public class Atendente
    {
        public Atendente(string cpf, string nome)
        {
            CPF = cpf;
            Nome = nome;
        }

        public string CPF { get; private set; }
        public string Nome { get; private set; }

        //todo Criar validação
    }

    //Entidade
    public class TipoExame
    {
        //Classificação Brasileira Hierarquizada de Procedimentos Médicos
        public TipoExame(string cbhpm, string descricao,Double valor)
        {
            CBHPM = cbhpm;
            Descricao = descricao;
            Valor = valor;
        }

        public string CBHPM { get; private set; }
        public string Descricao { get; private set; }
        public double Valor { get; set; }

        //Todo Criar método de validação
    }

    //Entidades
    public class Paciente
    {
        public Paciente(string cpf, string nome,string email)
        {
            CPF = cpf;
            Nome = nome;
        }

        public string CPF { get; private set; }
        public string Nome { get; private set; }
        public PlanoDeSaude PlanoDeSaude { get; private set; }
        public string Email { get; private set; }

        //Todo Criar método de validação
    }

    public class PlanoDeSaude
    {
        public PlanoDeSaude(string cnpj, string nome, string tipoDoPlano)
        {
            CNPJ = cnpj;
            Nome = nome;
            TipoDoPlano = tipoDoPlano;
        }

        public string CNPJ { get; private set; }
        public string Nome { get; private set; }
        public string TipoDoPlano { get; private set; }

        //todo incluir validação
    }

    //Entidade
    public class Medico
    {
        public Medico(string crm, string nome, string estado)
        {
            ValidarMedico(crm,nome,estado);
            CRM = crm;
            Nome = nome;
            Estado = estado;
        }

        private void ValidarMedico(string crm, string nome, string estado)
        {
            if (String.IsNullOrEmpty(crm))
                throw new Exception("CRM inválido");

            if (String.IsNullOrEmpty(nome))
                throw new Exception("Nome inválido");

            if (String.IsNullOrEmpty(estado))
                throw new Exception("Estado inválido");
        }

        public string CRM { get; private set; }//Identificador
        public string Nome { get; private set; }
        public string Estado { get; private set; }


    }

    //Exame
    public class Exame
    {
        
        public Exame(TipoExame tipoExame)
        {
            TipoExame = tipoExame;
        }

        public TipoExame TipoExame { get; private set; }
        public Laudo Laudo { get; private set; }

        public void EmitirLaudo(Laudo laudo)
        {
            Laudo = laudo;

        }
    }

    public class Laudo
    {
        public  readonly string Descricao;

        public Laudo(string descricao)
        {
            Descricao = descricao;
        }
    }
}
