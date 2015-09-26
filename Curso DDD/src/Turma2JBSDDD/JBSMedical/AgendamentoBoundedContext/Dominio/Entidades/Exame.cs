using System;
using JBSMedical.CadastrosBoundedContext.Dominio.Entidades;

namespace JBSMedical.AgendamentoBoundedContext.Dominio.Entidades
{
    public class Exame
    {
        public Exame(Guid newGuid, TipoExame tipoExame, double preco)
        {
            
            TipoExame = tipoExame;
            Preco = preco;
        }

        public Exame()
        {
        }

        public int ID { get; protected set; }
        public TipoExame TipoExame { get; protected set; }
        public double Preco { get; protected set; }

        
    }
}