using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace APS_5.Code
{
    static class ComunicacaoServidor
    {
        private static Connection conexao;
        private static string servidor;

        public static IList<string> ListarUsuariosOnline()
        {
            conexao = new Connection(servidor);
            dynamic resposta = conexao.SendData(new { tipo = "obter-usuarios-online"});
            if (resposta.status != "ok") return null;

            return resposta.data.ToObject<List<string>>();
        }

        public static bool EnviarMensagem(string mensagem)
        {
          //  Telas.telaChat
            return true;
        }

        public static bool Conectar(string nome, string servidorTemp)
        {



            try
            {
                servidor = servidorTemp;
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