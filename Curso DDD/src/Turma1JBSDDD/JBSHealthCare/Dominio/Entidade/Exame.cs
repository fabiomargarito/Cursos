namespace TestesUnitarios
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
    }
}