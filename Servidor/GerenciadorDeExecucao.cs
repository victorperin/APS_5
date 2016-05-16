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
        private static IList<Mensagem> mensagens = new List<Mensagem>();

        private static IList<string> UsuariosOnline()
        {
            IList<string> usuarios = new List<string>();
            foreach (var conexao in conexoes)
            {
                usuarios.Add(conexao.NomeUsuario);
            }
            return usuarios.Distinct().ToList();
        }

        private static void RemoverUsuario(string nome)
        {
            conexoes = conexoes.Where(x => x.NomeUsuario != nome).ToList();
        }
        public static void Gerenciar(Request request)
        {
            if (request.Data == null) return;
            switch ((string)request.Data.tipo)
            {
                case "definir-nome":
                    if (UsuariosOnline().Contains((string)request.Data.nome))
                    {
                        Comunicacao.SendResponse(request, new { status = "error" });
                        break;
                    }
                    Console.WriteLine("Usuario " + request.Data.nome + " conectou.");
                    request.NomeUsuario = request.Data.nome;
                    conexoes.Add(request);
                    Comunicacao.SendResponse(request, new { status = "ok" });
                    break;
                case "obter-usuarios-online":
                    Console.WriteLine("Enviando lista de usuarios.");
                    Comunicacao.SendResponse(request, new { status = "ok", data = UsuariosOnline() });
                    break;

                case "desconectar":
                    Comunicacao.SendResponse(request, new { status = "ok" });
                    RemoverUsuario((string)request.Data.usuario);
                    Console.WriteLine("Usuario " + request.Data.usuario + " desconectou.");
                    break;
                case "obter-mensagens":
                    Console.WriteLine(mensagens.Count);
                    Comunicacao.SendResponse(request, mensagens);
                    break;
                case "enviar-mensagem":
                    if (request.Data.mensagem.ToString().TrimEnd('\r', '\n') == "")
                    {
                        Comunicacao.SendResponse(request, new { status = "error" });
                        break;
                    }
                        
                    mensagens.Add(new Mensagem { usuario = request.Data.usuario, mensagem = request.Data.mensagem.ToString().TrimEnd( '\r', '\n' ) });
                    Comunicacao.SendResponse(request, new { status = "ok" });
                    Console.WriteLine(request.Data.usuario + " disse: " + request.Data.mensagem);
                    break;
            }
        }
    }
}
