using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APS_5.Code;

namespace APS_5.Forms
{
    public class FormBridge : Form
    {
        private bool continuarExecucao = false;
        protected void Close(bool continuarExecucaoTemp = false)
        {
            continuarExecucao = continuarExecucaoTemp;
            base.Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (continuarExecucao) return;

            Telas.usuariosThread.Abort();
            Telas.mensagensThread.Abort();
            ComunicacaoServidor.Desconectar();
            Application.Exit();
        }
    }
}
