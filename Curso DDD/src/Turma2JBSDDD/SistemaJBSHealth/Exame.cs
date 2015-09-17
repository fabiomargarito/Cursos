using System;

namespace SistemaJBSHealth
{
    public class Exame
    {
        public Exame(Guid newGuid, TipoExame tipoExame, double preco)
        {
            NewGuid = newGuid;
            TipoExame = tipoExame;
            Preco = preco;
        }

        public Exame()
        {
        }

        public Guid NewGuid { get; protected set; }
        public TipoExame TipoExame { get; protected set; }
        public double Preco { get; protected set; }

        
    }
}