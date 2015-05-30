using ClassLibrary1;

namespace AplicacaoTeste
{
    class Program
    {
        static void Main(string[] args)
        {

            Agendamento agendamento = new Agendamento(123,new Paciente("123","Fabio"),new Atendente("1234","fabio")); 
            agendamento.AdicionarExame(new Exame());

        }
    }
}
