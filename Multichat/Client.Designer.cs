namespace Lab3_Bai6
{
    partial class Client
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.grbMessage = new System.Windows.Forms.GroupBox();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblClientIP = new System.Windows.Forms.Label();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbConnect = new System.Windows.Forms.ListBox();
            this.rtbChatBox = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.grbMessage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(127, 128);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(56, 19);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // grbMessage
            // 
            this.grbMessage.Controls.Add(this.btnSendFile);
            this.grbMessage.Controls.Add(this.btnSend);
            this.grbMessage.Controls.Add(this.txtMessage);
            this.grbMessage.Location = new System.Drawing.Point(11, 346);
            this.grbMessage.Margin = new System.Windows.Forms.Padding(2);
            this.grbMessage.Name = "grbMessage";
            this.grbMessage.Padding = new System.Windows.Forms.Padding(2);
            this.grbMessage.Size = new System.Drawing.Size(662, 54);
            this.grbMessage.TabIndex = 6;
            this.grbMessage.TabStop = false;
            this.grbMessage.Text = "Message";
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(571, 17);
            this.btnSendFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(27, 26);
            this.btnSendFile.TabIndex = 2;
            this.btnSendFile.Text = "I";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(602, 17);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(56, 26);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Location = new System.Drawing.Point(4, 17);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(563, 26);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(66, 128);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 19);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblClientIP
            // 
            this.lblClientIP.AutoSize = true;
            this.lblClientIP.Location = new System.Drawing.Point(12, 25);
            this.lblClientIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientIP.Name = "lblClientIP";
            this.lblClientIP.Size = new System.Drawing.Size(46, 13);
            this.lblClientIP.TabIndex = 8;
            this.lblClientIP.Text = "Client IP";
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Location = new System.Drawing.Point(12, 56);
            this.lblServerPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(60, 13);
            this.lblServerPort.TabIndex = 9;
            this.lblServerPort.Text = "Server Port";
            // 
            // txtServerIP
            // 
            this.txtServerIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServerIP.Location = new System.Drawing.Point(83, 24);
            this.txtServerIP.Margin = new System.Windows.Forms.Padding(2);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(76, 20);
            this.txtServerIP.TabIndex = 10;
            this.txtServerIP.Text = "127.0.0.1";
            // 
            // txtServerPort
            // 
            this.txtServerPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServerPort.Location = new System.Drawing.Point(83, 54);
            this.txtServerPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(76, 20);
            this.txtServerPort.TabIndex = 11;
            this.txtServerPort.Text = "8888";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 87);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(83, 85);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(76, 20);
            this.txtUsername.TabIndex = 13;
            this.txtUsername.Text = "Wuoc";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtServerPort);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.lblClientIP);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.lblServerPort);
            this.groupBox1.Controls.Add(this.txtServerIP);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(172, 114);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // lbConnect
            // 
            this.lbConnect.FormattingEnabled = true;
            this.lbConnect.Location = new System.Drawing.Point(11, 153);
            this.lbConnect.Margin = new System.Windows.Forms.Padding(2);
            this.lbConnect.Name = "lbConnect";
            this.lbConnect.Size = new System.Drawing.Size(173, 186);
            this.lbConnect.TabIndex = 15;
            // 
            // rtbChatBox
            // 
            this.rtbChatBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbChatBox.Font = new System.Drawing.Font("Yu Gothic UI", 11F);
            this.rtbChatBox.Location = new System.Drawing.Point(189, 13);
            this.rtbChatBox.Name = "rtbChatBox";
            this.rtbChatBox.ReadOnly = true;
            this.rtbChatBox.Size = new System.Drawing.Size(484, 328);
            this.rtbChatBox.TabIndex = 16;
            this.rtbChatBox.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(679, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(199, 387);
            this.flowLayoutPanel1.TabIndex = 17;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 424);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.rtbChatBox);
            this.Controls.Add(this.lbConnect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Client";
            this.Text = "TCP Client";
            this.grbMessage.ResumeLayout(false);
            this.grbMessage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox grbMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblClientIP;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbConnect;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.RichTextBox rtbChatBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}