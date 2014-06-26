using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ObserverChegadaDeArquivo
{
    //subject
    public class Arquivo
    {
        List<IInteressado> interessados = new List<IInteressado>();
        
        public void monitorar()
        {
            FileSystemWatcher watcher = new FileSystemWatcher("c:\\");
            watcher.Changed += watcher_Changed;
        }

        void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            notificar();
        }

        public void cadastrarInteressado(IInteressado interessado)
        {
            interessados.Add(interessado);
        }

        public void removerInteressado(IInteressado interessado)
        {
            interessados.Remove(interessado);
        }

        public void notificar()
        {
            foreach(var interessado in interessados)
                interessado.Notificar();
        }
    }

    public interface IInteressado
    {
        void Notificar();
    }


    public class interesado:IInteressado
    {
        public void Notificar()
        {
            Console.WriteLine("arquivo criado/alterado");
        }
    }
}
