﻿using APS_5.Code;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaChat));
            this.labelUsuariosOnline = new System.Windows.Forms.Label();
            this.EnviarBotao = new System.Windows.Forms.Button();
            this.BotaoConfigChat = new System.Windows.Forms.Button();
            this.BoxUsuariosSala = new System.Windows.Forms.RichTextBox();
            this.BoxMensagemEnviar = new System.Windows.Forms.RichTextBox();
            this.BoxMensagens = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelUsuariosOnline
            // 
            this.labelUsuariosOnline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsuariosOnline.AutoSize = true;
            this.labelUsuariosOnline.BackColor = System.Drawing.Color.Black;
            this.labelUsuariosOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelUsuariosOnline.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUsuariosOnline.Location = new System.Drawing.Point(566, 9);
            this.labelUsuariosOnline.Name = "labelUsuariosOnline";
            this.labelUsuariosOnline.Size = new System.Drawing.Size(144, 22);
            this.labelUsuariosOnline.TabIndex = 7;
            this.labelUsuariosOnline.Text = "Usuários na sala";
            // 
            // EnviarBotao
            // 
            this.EnviarBotao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EnviarBotao.AutoEllipsis = true;
            this.EnviarBotao.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.EnviarBotao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EnviarBotao.BackgroundImage")));
            this.EnviarBotao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EnviarBotao.Cursor = System.Windows.Forms.Cursors.Default;
            this.EnviarBotao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnviarBotao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnviarBotao.Location = new System.Drawing.Point(670, 351);
            this.EnviarBotao.Name = "EnviarBotao";
            this.EnviarBotao.Size = new System.Drawing.Size(32, 32);
            this.EnviarBotao.TabIndex = 5;
            this.toolTip1.SetToolTip(this.EnviarBotao, "Enviar");
            this.EnviarBotao.UseCompatibleTextRendering = true;
            this.EnviarBotao.UseVisualStyleBackColor = false;
            this.EnviarBotao.Click += new System.EventHandler(this.EnviarBotao_Click);
            // 
            // BotaoConfigChat
            // 
            this.BotaoConfigChat.AllowDrop = true;
            this.BotaoConfigChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoConfigChat.BackColor = System.Drawing.Color.Black;
            this.BotaoConfigChat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotaoConfigChat.BackgroundImage")));
            this.BotaoConfigChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BotaoConfigChat.Enabled = false;
            this.BotaoConfigChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoConfigChat.Location = new System.Drawing.Point(670, 312);
            this.BotaoConfigChat.Name = "BotaoConfigChat";
            this.BotaoConfigChat.Size = new System.Drawing.Size(32, 32);
            this.BotaoConfigChat.TabIndex = 4;
            this.toolTip1.SetToolTip(this.BotaoConfigChat, "Configuração/Sair");
            this.BotaoConfigChat.UseVisualStyleBackColor = false;
            this.BotaoConfigChat.Visible = false;
            this.BotaoConfigChat.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BoxUsuariosSala
            // 
            this.BoxUsuariosSala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxUsuariosSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.BoxUsuariosSala.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxUsuariosSala.Enabled = false;
            this.BoxUsuariosSala.Location = new System.Drawing.Point(566, 37);
            this.BoxUsuariosSala.Name = "BoxUsuariosSala";
            this.BoxUsuariosSala.Size = new System.Drawing.Size(146, 257);
            this.BoxUsuariosSala.TabIndex = 3;
            this.BoxUsuariosSala.Text = "";
            this.BoxUsuariosSala.TextChanged += new System.EventHandler(this.BoxUsuariosSala_TextChanged);
            // 
            // BoxMensagemEnviar
            // 
            this.BoxMensagemEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxMensagemEnviar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BoxMensagemEnviar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxMensagemEnviar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BoxMensagemEnviar.Location = new System.Drawing.Point(12, 312);
            this.BoxMensagemEnviar.Name = "BoxMensagemEnviar";
            this.BoxMensagemEnviar.Size = new System.Drawing.Size(634, 74);
            this.BoxMensagemEnviar.TabIndex = 2;
            this.BoxMensagemEnviar.Text = "";
            this.BoxMensagemEnviar.TextChanged += new System.EventHandler(this.BoxMensagemEnviar_TextChanged);
            this.BoxMensagemEnviar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BoxMensagemEnviar_KeyDown);
            // 
            // BoxMensagens
            // 
            this.BoxMensagens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxMensagens.BackColor = System.Drawing.Color.White;
            this.BoxMensagens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxMensagens.EnableAutoDragDrop = true;
            this.BoxMensagens.Location = new System.Drawing.Point(12, 12);
            this.BoxMensagens.Name = "BoxMensagens";
            this.BoxMensagens.ReadOnly = true;
            this.BoxMensagens.Size = new System.Drawing.Size(548, 282);
            this.BoxMensagens.TabIndex = 1;
            this.BoxMensagens.Text = "";
            this.BoxMensagens.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // TelaChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(723, 398);
            this.Controls.Add(this.labelUsuariosOnline);
            this.Controls.Add(this.EnviarBotao);
            this.Controls.Add(this.BotaoConfigChat);
            this.Controls.Add(this.BoxUsuariosSala);
            this.Controls.Add(this.BoxMensagemEnviar);
            this.Controls.Add(this.BoxMensagens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaChat";
            this.Text = "Pruu";
            this.Load += new System.EventHandler(this.TelaChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox BoxMensagens;
        private System.Windows.Forms.RichTextBox BoxMensagemEnviar;
        private System.Windows.Forms.RichTextBox BoxUsuariosSala;
        private System.Windows.Forms.Button EnviarBotao;
        private System.Windows.Forms.Button BotaoConfigChat;
        private System.Windows.Forms.Label labelUsuariosOnline;
        private System.Windows.Forms.ToolTip toolTip1;


    }
}