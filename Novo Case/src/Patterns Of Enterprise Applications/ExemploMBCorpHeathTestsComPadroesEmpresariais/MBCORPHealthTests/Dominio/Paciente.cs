using System;

namespace MBCORPHealthTests
{    
    
    public class Paciente
    {
        public Paciente(string nome, string cpf)
        {

            if (string.IsNullOrEmpty(nome)) throw new Exception("nome inválido");
            if (string.IsNullOrEmpty(cpf)) throw new Exception("cpf inválido");

            Nome = nome;
            CPF = cpf;
        }

        public Paciente()
        {
        }

        public virtual string Nome { get; protected set; }
        public virtual string CPF { get; protected set; }
        public virtual Endereco Endereco { get; protected set; }
        public virtual PlanoSaude PlanoSaude { get; protected set; }
        public virtual CredencialAcesso CredencialAcesso { get; protected set; }

        public virtual void AdicionarEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        public virtual void DefinirPlanoDeSaude(PlanoSaude planoSaude)
        {
            PlanoSaude = planoSaude;
        }

        public virtual void DefinirCredencialDeAcesso(CredencialAcesso credencialAcesso)
        {
            CredencialAcesso= credencialAcesso;
        }

        public virtual CredencialAcesso GerarCredencialDeAcesso(TipoCredencial tipoCredencial, string nome)
        {
           
            if (tipoCredencial== TipoCredencial.Paciente)
                return  CredencialAcesso = new CredencialAcesso(Guid.NewGuid().ToString().Substring(1, 4) + this.Nome.Substring(1,4),this.CPF);

            if (tipoCredencial == TipoCredencial.Medico)
                return CredencialAcesso = new CredencialAcesso(Guid.NewGuid().ToString().Substring(1, 8), "12345" );

            if (tipoCredencial == TipoCredencial.Atendente)
                return CredencialAcesso = new CredencialAcesso(nome.Substring(1, 8), "56789");

            return null;
        }
    }

    public enum TipoCredencial
    {
        Medico,
        Paciente,
        Atendente
    }
}