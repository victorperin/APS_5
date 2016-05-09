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
        public static void Gerenciar(Request request) {
            try
            {
                switch ((string)request.Data.tipo)
                {
                    case "definir-nome":
                        Console.WriteLine("Usuario "+request.Data.nome+" conectou.");
                        Comunicacao.SendResponse(request, new { status="ok" });
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao gerenciar execução");
            }
            
        }
    }
}
