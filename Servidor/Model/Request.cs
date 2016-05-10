using System;
using System.Net.Sockets;

namespace Servidor.Model
{
        class Request
        {
            public TcpClient Client { get; set; }
            public NetworkStream Stream { get; set; }

            public dynamic Data { get; set; }

            public string NomeUsuario { get; set; }

            public DateTime DataAtualizacao { get; set; }
        }
}
