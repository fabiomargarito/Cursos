using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CommandTV
{
    public interface DispositoEletronico
    {
        void Ligar();
        void Desligar();
        void TrocarSintonia(int canal);
    }

    public class Televisao : DispositoEletronico
    {
        public void Ligar()
        {
            Console.WriteLine("TV Ligada");
        }

        public void Desligar()
        {
            Console.WriteLine("TV Desligada");
        }

        public void TrocarSintonia(int canal)
        {
            Console.WriteLine("Canal trocada para {0}", canal);
        }
    }

    public interface Comando
    {
        void Execute();
    }


    public class LigarTV : Comando
    {
        private DispositoEletronico TV;

        public LigarTV(DispositoEletronico dispositoEletronico)
        {
            TV = dispositoEletronico;
        }

        public void Execute()
        {
            TV.Ligar();
        }
    }

    public class DesligarTV : Comando
    {
        private DispositoEletronico TV;

        public DesligarTV(DispositoEletronico dispositoEletronico)
        {
            TV = dispositoEletronico;
        }

        public void Execute()
        {
            TV.Desligar();
        }
    }

    public class TrocarCanalTV : Comando
    {
        private DispositoEletronico TV;
        public int Canal { get; set; }

        public TrocarCanalTV(DispositoEletronico dispositoEletronico, int canal)
        {
            TV = dispositoEletronico;
            Canal = canal;
        }

       

        
        public void Execute()
        {
            TV.TrocarSintonia(Canal);
        }
    }



    public class ControleRemoto
    {

        public void Pressionar(Comando comando)
        {
            comando.Execute();
        }
    }
}
