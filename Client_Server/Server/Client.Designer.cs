namespace Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnShutServer = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEmoji = new System.Windows.Forms.Button();
            this.flpEmoji = new System.Windows.Forms.FlowLayoutPanel();
            this.txtEmoji = new System.Windows.Forms.TextBox();
            this.btnFindEmoji = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flpEmoji.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(6, 19);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(486, 34);
            this.rtbMessage.TabIndex = 3;
            this.rtbMessage.Text = "";
            this.rtbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbMessage_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.Location = new System.Drawing.Point(590, 19);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(180, 34);
            this.btnSend.TabIndex = 2;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(548, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Client Port";
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPort.Location = new System.Drawing.Point(688, 12);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 30);
            this.txtPort.TabIndex = 0;
            this.txtPort.Text = "8888";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(548, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtName.Location = new System.Drawing.Point(606, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 30);
            this.txtName.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnConnect.Location = new System.Drawing.Point(694, 84);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 30);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnShutServer
            // 
            this.btnShutServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnShutServer.Location = new System.Drawing.Point(594, 84);
            this.btnShutServer.Name = "btnShutServer";
            this.btnShutServer.Size = new System.Drawing.Size(94, 30);
            this.btnShutServer.TabIndex = 4;
            this.btnShutServer.Text = "Thoát";
            this.btnShutServer.UseVisualStyleBackColor = true;
            this.btnShutServer.Click += new System.EventHandler(this.btnShutServer_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(498, 19);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(40, 34);
            this.btnSendFile.TabIndex = 5;
            this.btnSendFile.Text = "F";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // rtbMain
            // 
            this.rtbMain.BackColor = System.Drawing.SystemColors.Window;
            this.rtbMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMain.Location = new System.Drawing.Point(12, 12);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.ReadOnly = true;
            this.rtbMain.Size = new System.Drawing.Size(538, 368);
            this.rtbMain.TabIndex = 6;
            this.rtbMain.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEmoji);
            this.groupBox1.Controls.Add(this.rtbMessage);
            this.groupBox1.Controls.Add(this.btnSendFile);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Location = new System.Drawing.Point(12, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 63);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message";
            // 
            // btnEmoji
            // 
            this.btnEmoji.Location = new System.Drawing.Point(544, 19);
            this.btnEmoji.Name = "btnEmoji";
            this.btnEmoji.Size = new System.Drawing.Size(40, 34);
            this.btnEmoji.TabIndex = 6;
            this.btnEmoji.Text = "E";
            this.btnEmoji.UseVisualStyleBackColor = true;
            this.btnEmoji.Click += new System.EventHandler(this.btnEmoji_Click);
            // 
            // flpEmoji
            // 
            this.flpEmoji.AutoScroll = true;
            this.flpEmoji.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpEmoji.Controls.Add(this.txtEmoji);
            this.flpEmoji.Controls.Add(this.btnFindEmoji);
            this.flpEmoji.Location = new System.Drawing.Point(272, 120);
            this.flpEmoji.Name = "flpEmoji";
            this.flpEmoji.Size = new System.Drawing.Size(525, 260);
            this.flpEmoji.TabIndex = 8;
            this.flpEmoji.Visible = false;
            // 
            // txtEmoji
            // 
            this.txtEmoji.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmoji.Location = new System.Drawing.Point(3, 3);
            this.txtEmoji.Name = "txtEmoji";
            this.txtEmoji.Size = new System.Drawing.Size(412, 20);
            this.txtEmoji.TabIndex = 0;
            // 
            // btnFindEmoji
            // 
            this.btnFindEmoji.Location = new System.Drawing.Point(421, 3);
            this.btnFindEmoji.Name = "btnFindEmoji";
            this.btnFindEmoji.Size = new System.Drawing.Size(75, 23);
            this.btnFindEmoji.TabIndex = 1;
            this.btnFindEmoji.Text = "Find";
            this.btnFindEmoji.UseVisualStyleBackColor = true;
            this.btnFindEmoji.Click += new System.EventHandler(this.btnFindEmoji_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.flpEmoji);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbMain);
            this.Controls.Add(this.btnShutServer);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.flpEmoji.ResumeLayout(false);
            this.flpEmoji.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnShutServer;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEmoji;
        private System.Windows.Forms.FlowLayoutPanel flpEmoji;
        private System.Windows.Forms.TextBox txtEmoji;
        private System.Windows.Forms.Button btnFindEmoji;
    }
}

