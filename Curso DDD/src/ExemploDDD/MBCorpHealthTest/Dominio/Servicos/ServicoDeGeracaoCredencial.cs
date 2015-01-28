using MBCorpHealthTest.Dominio.Contratos;
using MBCorpHealthTest.Dominio.Entidades;

namespace MBCorpHealthTest.Dominio.Servicos
{
    public class ServicoDeGeracaoCredencial:IServicoDeGeracaoCredencial
    {
        public Credencial Gerar(Paciente paciente)
        {
            return new Credencial (paciente.Email,paciente.CPF);
        }
    }
}