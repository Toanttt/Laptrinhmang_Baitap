namespace Client
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
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnShutServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbMain
            // 
            this.rtbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rtbMain.Location = new System.Drawing.Point(17, 15);
            this.rtbMain.Margin = new System.Windows.Forms.Padding(4);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.ReadOnly = true;
            this.rtbMain.Size = new System.Drawing.Size(711, 474);
            this.rtbMain.TabIndex = 0;
            this.rtbMain.Text = "";
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(16, 497);
            this.rtbMessage.Margin = new System.Windows.Forms.Padding(4);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(711, 41);
            this.rtbMessage.TabIndex = 3;
            this.rtbMessage.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.Location = new System.Drawing.Point(763, 488);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(278, 62);
            this.btnSend.TabIndex = 2;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(731, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Client Port";
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPort.Location = new System.Drawing.Point(917, 15);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(133, 36);
            this.txtPort.TabIndex = 0;
            this.txtPort.Text = "8888";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(731, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtName.Location = new System.Drawing.Point(808, 59);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 36);
            this.txtName.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnConnect.Location = new System.Drawing.Point(925, 103);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(125, 37);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnShutServer
            // 
            this.btnShutServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnShutServer.Location = new System.Drawing.Point(925, 148);
            this.btnShutServer.Margin = new System.Windows.Forms.Padding(4);
            this.btnShutServer.Name = "btnShutServer";
            this.btnShutServer.Size = new System.Drawing.Size(125, 37);
            this.btnShutServer.TabIndex = 4;
            this.btnShutServer.Text = "Thoát";
            this.btnShutServer.UseVisualStyleBackColor = true;
            this.btnShutServer.Click += new System.EventHandler(this.btnShutServer_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnShutServer);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.rtbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnShutServer;
    }
}

