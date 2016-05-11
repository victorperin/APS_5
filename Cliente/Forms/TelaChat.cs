using APS_5.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using APS_5.Code.Helpers;

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

        private void AtualizarUsuarios()
        {
            while (true)
            {
                string textoUsuariosOnline = "";
                Thread.Sleep(100);
                foreach (var usuario in ComunicacaoServidor.ListarUsuariosOnline())
                {
                    textoUsuariosOnline += usuario + "\n";
                }
                ThreadHelperClass.SetText(this, BoxUsuariosSala, textoUsuariosOnline);
                Thread.Sleep(3000);
            }
        }
        private void AtualizarMensagens()
        {
            while (true)
            {
                string mensagens = "";
                foreach (var mensagem in ComunicacaoServidor.ListarMensagens())
                {
                    mensagens += mensagem.usuario + ": " + mensagem.mensagem + "\n";
                }
                ThreadHelperClass.SetText(this, BoxMensagens, mensagens);
                Thread.Sleep(1000);
            }
        }

        private void TelaChat_Load(object sender, EventArgs e)
        {
            Thread usuariosThread = new Thread(new ThreadStart(AtualizarUsuarios));
            usuariosThread.Start();
            Thread mensagensThread = new Thread(new ThreadStart(AtualizarMensagens));
            mensagensThread.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Telas.telaConfig = new TelaConfig();
            Telas.telaConfig.Show();
        }

        private void EnviarBotao_Click(object sender, EventArgs e)
        {
            if (ComunicacaoServidor.EnviarMensagem(BoxMensagemEnviar.Text))
            {
                BoxMensagemEnviar.Clear();
            }

            else
            {
                MessageBox.Show("Não foi possível enviar sua mensagem, verifique sua conexão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        public void Close()
        {
        
        ComunicacaoServidor.Desconectar();
        
        
        
        }

        private void BoxMensagemEnviar_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxUsuariosSala_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
