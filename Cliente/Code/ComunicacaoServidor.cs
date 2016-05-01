using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_5.Code
{
    static class ComunicacaoServidor
    {
        public static bool EnviarMensagem(string mensagem)
        {
            return true;
        }

        public static bool EnviarNome(string nome)
        {
            return true;
        }

       // public static bool VerificarNovasMensagens(string)
        public static Mensagem ReceberMensagem()
        {
            return new Mensagem
            {
                NomeUsuario = "Victor",
                IpUsuario = "0.0.0.0",
                Texto = "Blablabla"
            };
        }
    }
}