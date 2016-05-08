using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Servidor
{
    class Program
    {
        static void Main(string[] args)
        {
            //RepeaterListener();
            RepeaterSend();
        }

        static void RepeaterListener()
        {
            while (true)
            {
                var listener = Comunicacao.Listener();
                if (listener != null)
                    Console.WriteLine(listener.Data.blablabla);
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
