using JBSHealthCare.Dominio.Entidade.BoundedContextCadastrosCorporativos;
using TestesUnitarios;

namespace JBSHealthCare.Aplicacao.Servico.BoundedContextGestaoPlanoSaude
{
    public interface IServicoDeConsultaAPlanoDeSaude
    {
        bool ConsultarCobertura(TipoExame tipoExame, PlanoSaude planoSaude);
    }
}