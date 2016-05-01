namespace APS_5.Forms
{
    partial class TelaChat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaChat));
            this.EnviarBotao = new System.Windows.Forms.Button();
            this.BoxMensagens = new System.Windows.Forms.RichTextBox();
            this.BoxMensagemEnviar = new System.Windows.Forms.RichTextBox();
            this.BoxUsuariosSala = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // EnviarBotao
            // 
            this.EnviarBotao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EnviarBotao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.EnviarBotao.Cursor = System.Windows.Forms.Cursors.Default;
            this.EnviarBotao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnviarBotao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnviarBotao.Location = new System.Drawing.Point(565, 313);
            this.EnviarBotao.Name = "EnviarBotao";
            this.EnviarBotao.Size = new System.Drawing.Size(146, 74);
            this.EnviarBotao.TabIndex = 0;
            this.EnviarBotao.Text = "Enviar";
            this.EnviarBotao.UseVisualStyleBackColor = false;
            this.EnviarBotao.Click += new System.EventHandler(this.button1_Click);
            // 
            // BoxMensagens
            // 
            this.BoxMensagens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxMensagens.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BoxMensagens.Enabled = false;
            this.BoxMensagens.Location = new System.Drawing.Point(12, 12);
            this.BoxMensagens.Name = "BoxMensagens";
            this.BoxMensagens.ReadOnly = true;
            this.BoxMensagens.Size = new System.Drawing.Size(547, 282);
            this.BoxMensagens.TabIndex = 1;
            this.BoxMensagens.Text = "";
            this.BoxMensagens.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // BoxMensagemEnviar
            // 
            this.BoxMensagemEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxMensagemEnviar.BackColor = System.Drawing.SystemColors.Window;
            this.BoxMensagemEnviar.Location = new System.Drawing.Point(12, 313);
            this.BoxMensagemEnviar.Name = "BoxMensagemEnviar";
            this.BoxMensagemEnviar.Size = new System.Drawing.Size(547, 74);
            this.BoxMensagemEnviar.TabIndex = 2;
            this.BoxMensagemEnviar.Text = "";
            // 
            // BoxUsuariosSala
            // 
            this.BoxUsuariosSala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxUsuariosSala.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BoxUsuariosSala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxUsuariosSala.Enabled = false;
            this.BoxUsuariosSala.Location = new System.Drawing.Point(565, 12);
            this.BoxUsuariosSala.Name = "BoxUsuariosSala";
            this.BoxUsuariosSala.Size = new System.Drawing.Size(146, 282);
            this.BoxUsuariosSala.TabIndex = 3;
            this.BoxUsuariosSala.Text = "";
            // 
            // TelaChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(723, 399);
            this.Controls.Add(this.BoxUsuariosSala);
            this.Controls.Add(this.BoxMensagemEnviar);
            this.Controls.Add(this.BoxMensagens);
            this.Controls.Add(this.EnviarBotao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaChat";
            this.Text = "Chat Daora";
            this.Load += new System.EventHandler(this.TelaChat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox BoxMensagens;
        private System.Windows.Forms.RichTextBox BoxMensagemEnviar;
        private System.Windows.Forms.RichTextBox BoxUsuariosSala;
        private System.Windows.Forms.Button EnviarBotao;


    }
}