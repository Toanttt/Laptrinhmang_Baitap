namespace TCP_server
{
    partial class Server
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
            this.btnListen = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.AutoSize = true;
            this.btnListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListen.Location = new System.Drawing.Point(12, 11);
            this.btnListen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(150, 41);
            this.btnListen.TabIndex = 0;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // txtChat
            // 
            this.txtChat.BackColor = System.Drawing.SystemColors.Window;
            this.txtChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChat.Location = new System.Drawing.Point(12, 56);
            this.txtChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtChat.Size = new System.Drawing.Size(689, 293);
            this.txtChat.TabIndex = 2;
            this.txtChat.TabStop = false;
            this.txtChat.TextChanged += new System.EventHandler(this.txtChat_TextChanged);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.btnListen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.TextBox txtChat;
    }
}

