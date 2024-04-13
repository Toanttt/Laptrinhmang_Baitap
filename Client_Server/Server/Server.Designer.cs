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
            this.showTableLayoutPanelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnSendImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.Location = new System.Drawing.Point(654, 405);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(140, 40);
            this.btnSend.TabIndex = 5;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbMessage
            // 
            this.rtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMessage.Location = new System.Drawing.Point(12, 405);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(545, 34);
            this.rtbMessage.TabIndex = 0;
            this.rtbMessage.Text = "";
            this.rtbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbMessage_KeyDown);
            // 
            // rtbMain
            // 
            this.rtbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rtbMain.Location = new System.Drawing.Point(12, 12);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.ReadOnly = true;
            this.rtbMain.Size = new System.Drawing.Size(535, 388);
            this.rtbMain.TabIndex = 3;
            this.rtbMain.Text = "";
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbServer.Location = new System.Drawing.Point(553, 12);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(151, 31);
            this.lbServer.TabIndex = 6;
            this.lbServer.Text = "Server Port";
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPort.Location = new System.Drawing.Point(559, 46);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 30);
            this.txtPort.TabIndex = 0;
            this.txtPort.Text = "8888";
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnOpenPort.Location = new System.Drawing.Point(559, 82);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(89, 31);
            this.btnOpenPort.TabIndex = 8;
            this.btnOpenPort.Text = "Open";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // showTableLayoutPanelButton
            // 
            this.showTableLayoutPanelButton.Location = new System.Drawing.Point(608, 405);
            this.showTableLayoutPanelButton.Margin = new System.Windows.Forms.Padding(2);
            this.showTableLayoutPanelButton.Name = "showTableLayoutPanelButton";
            this.showTableLayoutPanelButton.Size = new System.Drawing.Size(40, 40);
            this.showTableLayoutPanelButton.TabIndex = 9;
            this.showTableLayoutPanelButton.Text = "☺";
            this.showTableLayoutPanelButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Location = new System.Drawing.Point(552, 288);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(164, 112);
            this.tableLayoutPanel.TabIndex = 10;
            // 
            // btnSendImage
            // 
            this.btnSendImage.Location = new System.Drawing.Point(563, 405);
            this.btnSendImage.Name = "btnSendImage";
            this.btnSendImage.Size = new System.Drawing.Size(40, 40);
            this.btnSendImage.TabIndex = 11;
            this.btnSendImage.Text = "I";
            this.btnSendImage.UseVisualStyleBackColor = true;
            this.btnSendImage.Click += new System.EventHandler(this.btnSendImage_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSendImage);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.showTableLayoutPanelButton);
            this.Controls.Add(this.btnOpenPort);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.rtbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.Button showTableLayoutPanelButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button btnSendImage;
    }
}

