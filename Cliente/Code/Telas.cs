using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using APS_5.Forms;

namespace APS_5.Code
{
    public static class Telas
    {
        public static TelaInicial telaInicial;  
        public static TelaChat telaChat;
        public static TelaConfig telaConfig;
        public static TelaCreditos telaCreditos;
        public static Thread usuariosThread = null;
        public static Thread mensagensThread = null;
    }
}
