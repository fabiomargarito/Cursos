using System;

namespace MBCorpHealthTest.Dominio.Entidades
{
    public   class Medico
    {
        public   Medico(string crm, string nome, string estado)
        {
            ValidarMedico(crm, nome, estado);
            CRM = crm;
            Nome = nome;
            Estado = estado;
        }

        public   Medico()
        {
        }

        protected   virtual void ValidarMedico(string crm, string nome, string estado)
        {
            if (String.IsNullOrEmpty(crm))
                throw new Exception("CRM inválido");

            if (String.IsNullOrEmpty(nome))
                throw new Exception("Nome inválido");

            if (String.IsNullOrEmpty(estado))
                throw new Exception("Estado inválido");
        }

        public   virtual string CRM { get; protected set; }//Identificador
        public   virtual string Nome { get; protected set; }
        public   virtual string Estado { get; protected set; }


    }
}