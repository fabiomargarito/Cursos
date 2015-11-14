using System;
using System.Collections.Generic;

namespace ExemploDeCriacaoDeUmRepositorioTurma4
{
    public class RepositorioAtendenteFake : IRepositorioAtendente
    {
        
        public Atendente retornarPorCPF(string cpf)
        {
            return new Atendente(cpf,"Fabio Margarito",DateTime.Now);   
        }
        public bool Excluir(Atendente atendente)
        {
            return true;
        }
        public  bool Gravar(Atendente atendente)
        {
            return true;
        }
        public IList<Atendente> retornarTodos()
        {
            IList<Atendente> atendentes = new List<Atendente>();
            atendentes.Add(new Atendente("123456", "Fabio Margarito", DateTime.Now));
            atendentes.Add(new Atendente("789102", "Flavio Margarito", DateTime.Now));

            return atendentes;

        }
    }
}