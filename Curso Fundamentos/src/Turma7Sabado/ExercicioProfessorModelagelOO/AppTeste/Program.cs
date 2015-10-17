using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioProfessorModelagemOO;

namespace AppTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Medico pessoa;

            pessoa = new MedicoLaudo("Medico Fabio","23232");
            
            pessoa.ValidarDados();
            pessoa.ValidarCrm();


            //Principio de Lisko

            S o1 = new S();
            T o2 = new T();

            T p = o1;
            p = o2;

            //Princípio da inversão de dependência
            ServicoDeConsultaDeEndereco servicoDeConsulta = new ServicoDeConsultaDeEnderecoNoCorparativo();
        }
    }

     public class T
    {
    }


    public class S:T
    {
        
        
         
    }

}
