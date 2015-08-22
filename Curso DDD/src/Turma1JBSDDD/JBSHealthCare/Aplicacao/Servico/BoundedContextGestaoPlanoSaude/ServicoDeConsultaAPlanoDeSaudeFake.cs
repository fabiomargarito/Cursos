using JBSHealthCare.Dominio.Entidade.BoundedContextCadastrosCorporativos;
using TestesUnitarios;

namespace JBSHealthCare.Aplicacao.Servico.BoundedContextGestaoPlanoSaude
{
    public class ServicoDeConsultaAPlanoDeSaudeFake : IServicoDeConsultaAPlanoDeSaude
    {
        public bool ConsultarCobertura(TipoExame tipoExame, PlanoSaude planoSaude)
        {
            return true;
        }
    }
}