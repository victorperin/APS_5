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
                if (request.Data.tipo == "definir-nome")
                    Console.WriteLine(request.Data.nome);
                if (request.Data.tipo == "Mensagem")
                    Console.WriteLine(request.Data.texto);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao gerenciar execução");
            }
            
        }
    }
}
