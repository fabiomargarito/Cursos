using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa().CriarMedico().DefinirNome("Fabio").ConstruirMedicoComCRM("123");
        }
    }

    public class Pessoa
    {


        public Pessoa()
        {
        }

        public Pessoa CriarMedico()
        {
            return new Pessoa();
        }

        public Pessoa DefinirNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public Pessoa ConstruirMedicoComCRM(string crm)
        {
            CRM = crm;
            return this;
        }


        //Criar Pessoa comum
        public Pessoa(string nome, string rg)
        {
            Nome = nome;
            RG = rg;
        }

        public Pessoa(string nome, string crm,string cpf)
        {
            Nome = nome;
            CRM = crm;
            CPF = cpf;
        }

        public string Nome { get; private set; }
        public string RG { get; private set; }
        public string CPF { get; private set; }
        public string CRM { get; private set; }

        public void Correr()
        {
        }
    }
}
