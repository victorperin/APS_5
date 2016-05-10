using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servidor.Model;

namespace Servidor
{
    static class GerenciadorDeExecucao
    {
        private static IList<Request> conexoes = new List<Request>();

        private static IList<string> UsuariosOnline()
        {
            IList<string> usuarios = new List<string>();
            foreach (var conexao in conexoes)
            {
                usuarios.Add(conexao.NomeUsuario);
            }
            return usuarios.Distinct().ToList();
        }
        public static void Gerenciar(Request request)
        {
            if (request.Data == null) return;
            switch ((string)request.Data.tipo)
            {
                case "definir-nome":
                    Console.WriteLine("Usuario " + request.Data.nome + " conectou.");
                    request.NomeUsuario = request.Data.nome;
                    conexoes.Add(request);
                    Comunicacao.SendResponse(request, new { status = "ok" });
                    break;
                case "obter-usuarios-online":
                    Console.WriteLine("Enviando lista de usuarios");
                    Comunicacao.SendResponse(request, new { status = "ok", data = UsuariosOnline() });
                    break;

                case "desconectar":
                    Console.WriteLine("Usuario desconectou");
                    break;
                
            }
        }
    }
}
