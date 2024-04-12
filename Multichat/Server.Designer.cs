namespace Lab3_Bai6
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
            this.txtUserNumber = new System.Windows.Forms.TextBox();
            this.lblUserNumber = new System.Windows.Forms.Label();
            this.btnListen = new System.Windows.Forms.Button();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.btnShutServer = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnSendFlie = new System.Windows.Forms.Button();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.rtbChatBox = new System.Windows.Forms.RichTextBox();
            this.gbInfo.SuspendLayout();
            this.gbMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserNumber
            // 
            this.txtUserNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserNumber.Location = new System.Drawing.Point(157, 50);
            this.txtUserNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserNumber.Name = "txtUserNumber";
            this.txtUserNumber.Size = new System.Drawing.Size(101, 22);
            this.txtUserNumber.TabIndex = 11;
            this.txtUserNumber.Text = "2";
            // 
            // lblUserNumber
            // 
            this.lblUserNumber.AutoSize = true;
            this.lblUserNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNumber.Location = new System.Drawing.Point(5, 53);
            this.lblUserNumber.Name = "lblUserNumber";
            this.lblUserNumber.Size = new System.Drawing.Size(110, 20);
            this.lblUserNumber.TabIndex = 10;
            this.lblUserNumber.Text = "Default users";
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(169, 103);
            this.btnListen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(100, 30);
            this.btnListen.TabIndex = 9;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // txtServerPort
            // 
            this.txtServerPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServerPort.Location = new System.Drawing.Point(157, 21);
            this.txtServerPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(101, 22);
            this.txtServerPort.TabIndex = 7;
            this.txtServerPort.Text = "8888";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(5, 23);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(94, 20);
            this.lblPort.TabIndex = 6;
            this.lblPort.Text = "Server Port";
            // 
            // btnShutServer
            // 
            this.btnShutServer.Location = new System.Drawing.Point(63, 103);
            this.btnShutServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShutServer.Name = "btnShutServer";
            this.btnShutServer.Size = new System.Drawing.Size(100, 30);
            this.btnShutServer.TabIndex = 12;
            this.btnShutServer.Text = "Shut";
            this.btnShutServer.UseVisualStyleBackColor = true;
            this.btnShutServer.Click += new System.EventHandler(this.btnShutServer_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(507, 23);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 32);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Location = new System.Drawing.Point(5, 23);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(453, 32);
            this.txtMessage.TabIndex = 15;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblPort);
            this.gbInfo.Controls.Add(this.lblUserNumber);
            this.gbInfo.Controls.Add(this.txtServerPort);
            this.gbInfo.Controls.Add(this.txtUserNumber);
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbInfo.Size = new System.Drawing.Size(263, 85);
            this.gbInfo.TabIndex = 16;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            // 
            // btnSendFlie
            // 
            this.btnSendFlie.Location = new System.Drawing.Point(464, 23);
            this.btnSendFlie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendFlie.Name = "btnSendFlie";
            this.btnSendFlie.Size = new System.Drawing.Size(36, 32);
            this.btnSendFlie.TabIndex = 17;
            this.btnSendFlie.Text = "I";
            this.btnSendFlie.UseVisualStyleBackColor = true;
            this.btnSendFlie.Click += new System.EventHandler(this.btnSendFlie_Click);
            // 
            // gbMessage
            // 
            this.gbMessage.Controls.Add(this.txtMessage);
            this.gbMessage.Controls.Add(this.btnSendFlie);
            this.gbMessage.Controls.Add(this.btnSend);
            this.gbMessage.Location = new System.Drawing.Point(285, 421);
            this.gbMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMessage.Size = new System.Drawing.Size(612, 71);
            this.gbMessage.TabIndex = 18;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "Message";
            // 
            // rtbChatBox
            // 
            this.rtbChatBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbChatBox.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbChatBox.Location = new System.Drawing.Point(296, 12);
            this.rtbChatBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbChatBox.Name = "rtbChatBox";
            this.rtbChatBox.ReadOnly = true;
            this.rtbChatBox.Size = new System.Drawing.Size(600, 402);
            this.rtbChatBox.TabIndex = 19;
            this.rtbChatBox.Text = "";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 506);
            this.Controls.Add(this.rtbChatBox);
            this.Controls.Add(this.gbMessage);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnShutServer);
            this.Controls.Add(this.btnListen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Server";
            this.Text = "TCP Server";
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbMessage.ResumeLayout(false);
            this.gbMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserNumber;
        private System.Windows.Forms.Label lblUserNumber;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnShutServer;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button btnSendFlie;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.RichTextBox rtbChatBox;
    }
}