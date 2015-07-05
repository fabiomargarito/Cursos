namespace MBCorpHealth.Dominio
{
    public class Credencial
    {

        public Credencial()
        {
        }

        public virtual int ID { get; set; }
        public virtual string NomeDeUsuario { get; protected set; }
        public virtual string Senha { get; protected set; }


        public virtual Credencial GerarCredencialInicial(Pessoa pessoa)
        {
            NomeDeUsuario = string.Format("{0}{1}", pessoa.Nome.Split(' ')[0], pessoa.CPF);
            Senha =  pessoa.CPF;
            return this;
        }




      
    }
}
