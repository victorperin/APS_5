using APS_5.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS_5.Forms
{
    public partial class TelaChat : FormBridge
    {
        public TelaChat()
        {
            
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TelaChat_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Telas.telaConfig = new TelaConfig();
            Telas.telaConfig.Show();
        }

        private void EnviarBotao_Click(object sender, EventArgs e)
        {
            foreach (var usuario in ComunicacaoServidor.ListarUsuariosOnline())
            {
                MessageBox.Show(usuario);
            }
            if (ComunicacaoServidor.EnviarMensagem(BoxMensagemEnviar.Text))
            {
                BoxMensagemEnviar.Clear();
            }

            else
            {
                MessageBox.Show("Não foi possível enviar sua mensagem, verifique sua conexão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void BoxMensagemEnviar_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxUsuariosSala_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
