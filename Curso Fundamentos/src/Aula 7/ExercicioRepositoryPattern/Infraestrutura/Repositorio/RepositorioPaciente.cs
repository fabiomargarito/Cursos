using System;
using System.Collections.Generic;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos.Repositorio;

namespace MBCorpHealthUnitTest
{
    public class PacientesSQL:IRepositorio<Paciente>
    {
        public bool Gravar(Paciente entidade)
        {
            return true;
        }

        public bool Excluir(Paciente entidade)
        {
            return true;
        }

        public IList<Paciente> ConsultarPorID(int identificador)
        {
            //Comando do framework .net para gravação(sqlconnection, sqlcommand)

            IList<Paciente> listaDePacientes = new List<Paciente>();
            listaDePacientes.Add(new Paciente("Fabio", "29999"));
            listaDePacientes.Add(new Paciente("Fabio2", "299991"));
            listaDePacientes.Add(new Paciente("Fabio3", "299992"));
            listaDePacientes.Add(new Paciente("Fabio4", "299993"));

            return listaDePacientes;
        }

        public IList<Paciente> ConsultarPorTrechoNome(string nome)
        {
            //Comando do framework .net para gravação(sqlconnection, sqlcommand)

            IList<Paciente> listaDePacientes = new List<Paciente>();
            listaDePacientes.Add(new Paciente("Fabio", "29999"));
            listaDePacientes.Add(new Paciente("Fabio2", "299991"));
            listaDePacientes.Add(new Paciente("Fabio3", "299992"));
            listaDePacientes.Add(new Paciente("Fabio4", "299993"));

            return listaDePacientes;
        }
    }

    public class PacientesFake : IRepositorio<Paciente>
    {
        public bool Gravar(Paciente entidade)
        {
            //Comando do framework .net para gravação(sqlconnection, sqlcommand)
            return true;

        }

        public bool Excluir(Paciente entidade)
        {
            //Comando do framework .net para gravação(sqlconnection, sqlcommand)
            return true;
        }

        public IList<Paciente> ConsultarPorID(int identificador)
        {
            //Comando do framework .net para gravação(sqlconnection, sqlcommand)

            IList<Paciente> listaDePacientes = new List<Paciente>();
            listaDePacientes.Add(new Paciente("Fabio", "29999"));
            listaDePacientes.Add(new Paciente("Fabio2", "299991"));
            listaDePacientes.Add(new Paciente("Fabio3", "299992"));
            listaDePacientes.Add(new Paciente("Fabio4", "299993"));

            return listaDePacientes;

        }

        public IList<Paciente> ConsultarPorTrechoNome(string nome)
        {
            //Comando do framework .net para gravação(sqlconnection, sqlcommand)

            IList<Paciente> listaDePacientes = new List<Paciente>();
            listaDePacientes.Add(new Paciente("Fabio", "29999"));
            listaDePacientes.Add(new Paciente("Fabio2", "299991"));
            listaDePacientes.Add(new Paciente("Fabio3", "299992"));
            listaDePacientes.Add(new Paciente("Fabio4", "299993"));

            return listaDePacientes;
        }
    }
        
    public class PacienteNHibernate:IRepositorio<Paciente>
    {
        public bool Gravar(Paciente entidade)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(Paciente entidade)
        {
            throw new NotImplementedException();
        }

        public IList<Paciente> ConsultarPorID(int identificador)
        {
            throw new NotImplementedException();
        }

        public IList<Paciente> ConsultarPorTrechoNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}