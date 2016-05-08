using System.Text;
using System.Net.Sockets;

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

        public string SendData(string data)
        {
            NetworkStream nwStream = servidor.GetStream();
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(data);
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);

            byte[] bytesToRead = new byte[servidor.ReceiveBufferSize];

            int bytesRead = nwStream.Read(bytesToRead, 0, servidor.ReceiveBufferSize);

            return Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);
        }

        public void Reconnect(){
            servidor = new TcpClient(endereco, PORTA);
        }

        public void Disconnect(){
            servidor.Close();
        }
    }
}
