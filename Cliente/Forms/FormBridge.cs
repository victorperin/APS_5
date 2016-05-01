using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS_5.Forms
{
    public class FormBridge : Form
    {
        private bool continuarExecucao = false;
        protected void Close(bool continuarExecucaoTemp)
        {
            continuarExecucao = continuarExecucaoTemp;
            base.Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (!continuarExecucao)
                Application.Exit();
        }
    }
}
