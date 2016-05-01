using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using Newtonsoft.Json;

namespace Servidor
{
    static class Comunicacao
    {
        const int PORT_NO = 5000;
        const string SERVER_IP = "127.0.0.1";
        public static void Send(Request requestToSend)
        {
            try
            {
                string textToSend = JsonConvert.SerializeObject(requestToSend.Data);
                //---create a TCPClient object at the IP and port no.---
                TcpClient client = requestToSend.Client;
                NetworkStream nwStream = client.GetStream();

                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);

                //---send the text---
                Console.WriteLine("Sending : " + textToSend);
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);

                //---read back the text---
                //byte[] bytesToRead = new byte[client.ReceiveBufferSize];

                //int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
                //Console.WriteLine("Received : " + Encoding.ASCII.GetString(bytesToRead, 0, bytesRead));
                client.Close();
            }
            catch (SocketException e)
            {
                Console.WriteLine("Falha na conexão");
            }
            catch(Exception e)
            {
                Send(requestToSend);
            }
        }




        public static Request Listener()
        {
            //---listen at the specified IP and port no.---
            try
            {
                IPAddress localAdd = IPAddress.Parse(SERVER_IP);
                TcpListener listener = new TcpListener(localAdd, PORT_NO);
                Console.WriteLine("Listening... Port: " + PORT_NO);
                listener.Start();

                //---incoming client connected---
                TcpClient client = listener.AcceptTcpClient();

                //---get the incoming data through a network stream---
                NetworkStream nwStream = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];

                //---read incoming stream---
                int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);

                //---convert the data received into a json and return as a Request---
                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                return new Request { Client = client, Data = JsonConvert.DeserializeObject(dataReceived) };

                //---write back the text to the client---
                //Console.WriteLine("Sending back : " + dataReceived);
                //nwStream.Write(buffer, 0, bytesRead);
                client.Close();
                listener.Stop();
            }catch(Exception e){
                return null;
            }

            
        }

    }
    public class Request
    {
        public TcpClient Client { get; set; }
        public dynamic Data { get; set; }
    }
}
