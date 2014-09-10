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

        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public Endereco Endereco { get; private set; }
        public PlanoSaude PlanoSaude { get; private set; }
        public CredencialAcesso CredencialAcesso { get; private set; }

        public void AdicionarEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        public void DefinirPlanoDeSaude(PlanoSaude planoSaude)
        {
            PlanoSaude = planoSaude;
        }

        public CredencialAcesso GerarCredencialDeAcesso(TipoCredencial tipoCredencial, string nome)
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