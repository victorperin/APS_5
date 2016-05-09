using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_5.Code
{
    static class ComunicacaoServidor
    {
        private static Connection conexao;
        public static bool EnviarMensagem(string mensagem)
        {
          //  Telas.telaChat
            return true;
        }

        public static bool Conectar(string nome, string servidor)
        {



            try
            {
                conexao = new Connection(servidor);
                dynamic resposta = conexao.SendData(new { tipo = "definir-nome", nome = nome});
                if (resposta.status == "ok")
                    return true;
                else
                    return false;
            }

            catch(Exception e) {


                return false;
            
            }
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