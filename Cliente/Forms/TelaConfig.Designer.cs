namespace APS_5.Forms
{
    partial class TelaConfig
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
            this.BotaoVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotaoVoltar
            // 
            this.BotaoVoltar.Location = new System.Drawing.Point(332, 198);
            this.BotaoVoltar.Name = "BotaoVoltar";
            this.BotaoVoltar.Size = new System.Drawing.Size(112, 34);
            this.BotaoVoltar.TabIndex = 0;
            this.BotaoVoltar.Text = "BotaoVoltar";
            this.BotaoVoltar.UseVisualStyleBackColor = true;
            // 
            // TelaConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 244);
            this.Controls.Add(this.BotaoVoltar);
            this.Name = "TelaConfig";
            this.Text = "TelaConfig";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotaoVoltar;
    }
}