namespace Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.lbServer = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.btnShut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.Location = new System.Drawing.Point(760, 478);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(282, 63);
            this.btnSend.TabIndex = 5;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbMessage
            // 
            this.rtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMessage.Location = new System.Drawing.Point(16, 497);
            this.rtbMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(711, 41);
            this.rtbMessage.TabIndex = 0;
            this.rtbMessage.Text = "";
            // 
            // rtbMain
            // 
            this.rtbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rtbMain.Location = new System.Drawing.Point(16, 15);
            this.rtbMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.ReadOnly = true;
            this.rtbMain.Size = new System.Drawing.Size(712, 474);
            this.rtbMain.TabIndex = 3;
            this.rtbMain.Text = "";
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbServer.Location = new System.Drawing.Point(737, 15);
            this.lbServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(188, 39);
            this.lbServer.TabIndex = 6;
            this.lbServer.Text = "Server Port";
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPort.Location = new System.Drawing.Point(745, 57);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(133, 36);
            this.txtPort.TabIndex = 0;
            this.txtPort.Text = "8888";
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnOpenPort.Location = new System.Drawing.Point(745, 101);
            this.btnOpenPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(119, 38);
            this.btnOpenPort.TabIndex = 8;
            this.btnOpenPort.Text = "Open";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // btnShut
            // 
            this.btnShut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnShut.Location = new System.Drawing.Point(872, 101);
            this.btnShut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShut.Name = "btnShut";
            this.btnShut.Size = new System.Drawing.Size(119, 38);
            this.btnShut.TabIndex = 8;
            this.btnShut.Text = "Shut";
            this.btnShut.UseVisualStyleBackColor = true;
            this.btnShut.Click += new System.EventHandler(this.btnShutPort_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnShut);
            this.Controls.Add(this.btnOpenPort);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.rtbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.Button btnShut;
    }
}

