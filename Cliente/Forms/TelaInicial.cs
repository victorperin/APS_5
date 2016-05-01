using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APS_5.Code;
using APS_5.Forms;

namespace APS_5.Forms
{
    public partial class TelaInicial : FormBridge
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telas.telaChat = new TelaChat();
            Telas.telaChat.Show();
            Telas.telaInicial.Close(true);
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
