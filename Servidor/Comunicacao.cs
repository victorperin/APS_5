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
        const int PORT_NO = 3000;
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
                byte[] bytesToRead = new byte[client.ReceiveBufferSize];

                int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
                Console.WriteLine("Received : " + Encoding.ASCII.GetString(bytesToRead, 0, bytesRead));
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
            
            try
            {
                //listen at the specified IP and port no.
                IPAddress localAdd = IPAddress.Parse(GetLocalIPAddress());
                TcpListener listener = new TcpListener(localAdd, PORT_NO);
                listener.Start();

                //incoming client connected
                TcpClient client = listener.AcceptTcpClient();

                //get the incoming data through a network stream
                NetworkStream nwStream = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];

                //read incoming stream
                int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);

                //convert the data received into a json and return as a Request
                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                

                //write back the text to the client
                nwStream.Write(buffer, 0, bytesRead);
                //client.Close();
                listener.Stop();

                return new Request { Client = client, Stream = nwStream, Data = JsonConvert.DeserializeObject(dataReceived) };
            }catch(Exception e){
                return null;
            }

            
        }
        public static void SendResponse(Request request){
            byte[] buffer = new byte[request.Client.ReceiveBufferSize];
        }
        private static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }
        public static string getAddress()
        {
            return GetLocalIPAddress()+":"+PORT_NO;
        }
    }
    public class Request
    {
        public TcpClient Client { get; set; }
        public NetworkStream Stream { get; set; }
        public dynamic Data { get; set; }
    }
}
