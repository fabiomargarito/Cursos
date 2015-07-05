using System;
using System.CodeDom;
using System.Collections.Generic;
using ClassLibrary1;

namespace ClassLibrary1
{
    public class Pessoa
    {
        public Pessoa(string cpf, string nome)
        {
            ValidarDadosDeEntrada(cpf, nome);

            Cpf = cpf;
            Nome = nome;
        }

        private void ValidarDadosDeEntrada(string cpf, string nome)
        {
            IList<string> erros = new List<string>();

            if (String.IsNullOrEmpty(cpf))
                erros.Add("Cpf Inválido!!!");
                

            if (String.IsNullOrEmpty(nome))
                erros.Add("Nome Inválido!!!");


            if (erros.Count>0)
                //fazer um looping para montrar a mensagem
                throw new ArgumentException("erro da lista");
        }

        public string Cpf { get; private set; }
        public string Nome { get; private set; }
    }


    public class Atendente:Pessoa
    {
        public Atendente(string cpf, string nome) : base(cpf, nome)
        {

        }
    }

    public class Paciente:Pessoa
    {        
        public Endereco Endereco { get; private set; }
        public PlanoDeSaude PlanoDeSaude { get; private set; }

        public void DefinirEndereco(Endereco endereco)
        {
            if(endereco==null)
                throw new ArgumentException("Endereco Vazio!Insira uma valor válido");
            if(endereco.Logradouro == "")
                throw new ArgumentException("Endereco.Logradouro Vazio!Insira uma valor válido");

            Endereco = endereco;
        }

        public void DefinirPlanoDeSaude(PlanoDeSaude planoDeSaude)
        {
            PlanoDeSaude = planoDeSaude;
        }

        public Paciente(string cpf, string nome) : base(cpf, nome)
        {
        }
    }

    public class Medico
    {
        public string CRM { get; set; }
        public string Nome { get; set; }
    }

    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

    }

    public class PlanoDeSaude
    {
        public string Cnpj { get; set; }
        public string Nome { get; set; }                
    }

    public class Procedimento
    {
        public string CBHPM { get; set; }
        public string Descricao { get; set; }
    }


    public abstract class CredencialBase
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }


        public abstract Credencial GerarCredencial(string cpf);

    }

    public abstract class CredencialBaseAvancada : CredencialBase
    {
        public abstract Credencial GerarCredencialToken(string cpf, string token);
    }




    public class Credencial : CredencialBase
    {
        public override Credencial GerarCredencial(string cpf)
        {
         
                Usuario = cpf;
            Senha = string.Format("{0}{1}", cpf, Guid.NewGuid());
            return new Credencial { Usuario = Usuario, Senha = Senha };
        }
    }

    public class CredencialSuperComplexo : CredencialBase
    {
        public override Credencial GerarCredencial(string cpf)
        {
            Usuario = string.Format("{0}{1}", cpf, DateTime.Now.ToString());
            Senha = string.Format("{0}{1}{1}", cpf, DateTime.Now.ToString(), Guid.NewGuid());

            return new Credencial {Usuario = Usuario, Senha = Senha};
        }

    }
}
    public class CredencialComplexo : CredencialBase
    {
        public override Credencial GerarCredencial(string cpf)
        {
                Usuario = cpf;
                Senha = string.Format("{0}{1}{1}", cpf, DateTime.Now.ToString(), Guid.NewGuid());

            return new Credencial {Usuario = Usuario, Senha = Senha};
        }


        

    public class Agendamento
    {
        public Agendamento(int numero, Paciente paciente, Atendente atendente)
        {
            Numero = numero;
            Paciente = paciente;
            Atendente = atendente;

            Exames = new List<Exame>();
        }

        public int Numero { get; private set; }

        public Paciente Paciente { get; private set; }

        public Atendente Atendente { get; private set; }
        public Medico Medico { get; private set; }
        public IEnumerable<Exame> Exames { get; private set; }
        public Credencial Credencial { get; private set; }



        public virtual void AdicionarExame(Exame exame)
        {   
            if(exame==null)
                    throw new ArgumentException("Exame está nulo!!!");
            ((IList<Exame>) Exames).Add(exame);            

        }

    }

    public class AgendamentoPlus : Agendamento {
        public AgendamentoPlus(int numero, Paciente paciente, Atendente atendente) : base(numero, paciente, atendente)
        {
        }

        public override void AdicionarExame(Exame exame)
        {
            if (exame == null)
                throw new ArgumentException("Exame está nulo!!!");

            if (string.IsNullOrEmpty(exame.Procedimento.CBHPM))
                throw new ArgumentException("Exame.Procedimento está nulo ou vazio, verifique !!!");

            ((IList<Exame>)Exames).Add(exame);

        }
    }
 

    public class Resultado
    {
        public Medico Medico { get; set; }
        public string Descricao { get; set; }
        public DateTime DataConclusao { get; set; }
         
    }

    public class Exame
    {
        public Procedimento Procedimento { get; set; }
        public DateTime ?DataAgendada { get; set; }
        public Resultado Resultado { get; set; }    
    }

}

    public class CredencialSimples:CredencialBase
    {
        public override Credencial GerarCredencial(string cpf)
        {
            Usuario = cpf;
            Senha = cpf;
        return new Credencial { Usuario = Usuario, Senha = Senha };
    }
    }

public class CredencialMaster:CredencialBase
{
    public string Token { get; set; }

    public override Credencial GerarCredencial(string cpf)
    {
        Usuario = cpf;
        Senha = string.Format("{0}{1}{2}", cpf, DateTime.Now.ToString(), Guid.NewGuid());

        return new Credencial { Usuario = Usuario, Senha = Senha };
    }

    
}

public class Retangulo
{
    public int lado1 { get; set; }
    public int lado2 { get; set; }

    public virtual int CalcularArea()
    {
        return lado1*lado2;
    }
}

public class Quadrado : Retangulo
{
    public override int CalcularArea()
    {
        return lado1 * lado1;
    }
}


public class S:T
{
    public int calcular()
    {
        return 1;
    }

}

public class T
{
    public int calcular()
    {
        return 1;
    }
}


public interface IContratoDeTrabalho
{
    
    double EntregarLinhaDeCodigo2(int qtdLinhasDeCodigo);

    
}


public interface IMinutaDeContrato
{
    string GerarClausulaDeContrato();
}

public class MeuContratoDeTrabalho:IContratoDeTrabalho
{

    public double EntregarLinhaDeCodigo2(int qtdLinhasDeCodigo)
    {
        return qtdLinhasDeCodigo*1;
    }

}

public interface ICalculoFrete
{
     double CalcularFrente(double peso);
}

public class CalculoFreteSp:ICalculoFrete
{
    public double CalcularFrente(double peso)
    {
        return peso*0.10;
    }
}

public class CalculoFrenteSpNovo:ICalculoFrete
{
    public double CalcularFrente(double peso)
    {
        return peso*1.5;
    }
}

public class CalculoFreteRj:ICalculoFrete
{
    public double CalcularFrente(double peso)
    {
        return peso * 0.20;
    }
}


public class CalculoFreteMg : ICalculoFrete
{
    public double CalcularFrente(double peso)
    {
        return peso * 0.30;
    }
}

public interface IFabricaDeFretes
{
    ICalculoFrete CriarCalculoDeFrete(TipoDeFrete tipoDeFrete);
}

public class FabricaDeFretes:IFabricaDeFretes
{
    public ICalculoFrete CriarCalculoDeFrete(TipoDeFrete tipoDeFrete)
    {
        switch (tipoDeFrete)
        {
                case TipoDeFrete.RJ:return new CalculoFreteRj();
                case TipoDeFrete.MG:return new CalculoFreteMg();
                case TipoDeFrete.SP:return new CalculoFrenteSpNovo();
                default:   throw new Exception("frente não existe para este estado!!!!!");
        }
    }
}

public enum TipoDeFrete
{
    RJ,
    SP,
    MG
}




