using JBSHealthCare.Dominio.Entidade.BoundedContextCadastrosCorporativos;

namespace JBSHealthCare.Dominio.Entidade.BoundedContextGestaoDeAgendamentos
{
    public class Exame
    {
        public Exame(string s)
        {
            ID = "123";
        }

        public Exame()
        {
        }

        public virtual string ID { get; protected set; }
        public virtual string Descricao { get; protected set; }
        public virtual TipoExame TipoExame { get; protected set; }

        public void InformarTipoExame(TipoExame tipoExame)
        {
            TipoExame = tipoExame;
        }
    }
}