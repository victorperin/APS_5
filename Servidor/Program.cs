using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Servidor.Model;
using System.Net;

namespace Servidor
{
    class Program
    {
        static void Main(string[] args)
        {
            RepeaterListener();
            //RepeaterSend();
        }

        static void RepeaterListener()
        {
            IPAddress localAdd = IPAddress.Parse(Comunicacao.GetLocalIPAddress());
            TcpListener listener = new TcpListener(localAdd, 3000);
            listener.Start();
            while (true)
            {
                GerenciadorDeExecucao.Gerenciar(Comunicacao.Listener(listener));
            }
                
        }
        static void RepeaterSend()
        {
            while (true)
            {
                Random r = new Random();
                Console.WriteLine(r.Next(5, 10));
                try
                {
                    TcpClient client = new TcpClient("127.0.0.1", 5000);
                    Comunicacao.Send(new Request { Client = client, Data = new { teste = 10, blablabla = "teste" } });
                }
                catch (Exception e)
                {
                }
                
                
            }
        }
    }
}
