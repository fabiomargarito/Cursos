using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using FluentNHibernate.Utils;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos;
using NHibernate;
using NHibernate.Impl;

namespace MBCorpHealth.Infraestrutura.Repositorio
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly ISession _sessao;

        public RepositorioPaciente(ISession sessao)
        {
            _sessao = sessao;
        }

        public bool Gravar(Paciente paciente)
        {

            _sessao.SaveOrUpdate(paciente);
            _sessao.Flush();

            
            return true;
        }

        public List<Paciente> RetornarPorTrechoNome(string fa)
        {
            List<Paciente> pacientes = new List<Paciente>();

            
                pacientes =
                    _sessao.QueryOver<Paciente>().List().ToList();
            

            return pacientes;
        }

        public bool Excluir(Paciente paciente)
        {

            _sessao.Delete(paciente);
            _sessao.Flush();
            
            return true;
        }
    }

    }

