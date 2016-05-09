using System.Text;
using System.Net.Sockets;
using System;
using Newtonsoft.Json;

namespace APS_5.Code
{
    class Connection
    {
        private const int PORTA = 3000;
        private string endereco;
        private TcpClient servidor;

        public Connection(string enderecoTemp) {
                endereco = enderecoTemp;
                servidor = new TcpClient(endereco, PORTA);

        }

        public dynamic SendData(dynamic data)
        {
            NetworkStream nwStream = servidor.GetStream();
            string dataString = JsonConvert.SerializeObject(data);
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(dataString);
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);

            byte[] bytesToRead = new byte[servidor.ReceiveBufferSize];

            int bytesRead = nwStream.Read(bytesToRead, 0, servidor.ReceiveBufferSize);

            var stringRead = Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);
            var objectRead = JsonConvert.DeserializeObject(stringRead);

            return objectRead;
        }

        public void Reconnect(){
            servidor = new TcpClient(endereco, PORTA);
        }

        public void Disconnect(){
            servidor.Close();
        }
    }
}
