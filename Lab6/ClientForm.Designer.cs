namespace Lab6
{
    partial class ClientForm
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
            tbIP = new TextBox();
            btnConnect = new Button();
            tbName = new TextBox();
            lsvMessage = new ListView();
            label1 = new Label();
            label2 = new Label();
            btnSend = new Button();
            tbMessage = new TextBox();
            gbChat = new GroupBox();
            gbInfo = new GroupBox();
            gbChat.SuspendLayout();
            gbInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tbIP
            // 
            tbIP.Location = new Point(173, 36);
            tbIP.Name = "tbIP";
            tbIP.Size = new Size(135, 23);
            tbIP.TabIndex = 5;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(245, 84);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(9, 36);
            tbName.Name = "tbName";
            tbName.Size = new Size(135, 23);
            tbName.TabIndex = 6;
            tbName.Text = "Hieu";
            // 
            // lsvMessage
            // 
            lsvMessage.Location = new Point(9, 22);
            lsvMessage.Name = "lsvMessage";
            lsvMessage.Size = new Size(299, 248);
            lsvMessage.TabIndex = 7;
            lsvMessage.UseCompatibleStateImageBehavior = false;
            lsvMessage.View = View.Tile;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 18);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 18);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 9;
            label2.Text = "Server IP";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(233, 276);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 10;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(11, 276);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(216, 23);
            tbMessage.TabIndex = 11;
            // 
            // gbChat
            // 
            gbChat.Controls.Add(lsvMessage);
            gbChat.Controls.Add(btnSend);
            gbChat.Controls.Add(tbMessage);
            gbChat.Location = new Point(6, 110);
            gbChat.Name = "gbChat";
            gbChat.Size = new Size(314, 320);
            gbChat.TabIndex = 12;
            gbChat.TabStop = false;
            gbChat.Text = "Chat";
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(tbIP);
            gbInfo.Controls.Add(label2);
            gbInfo.Controls.Add(tbName);
            gbInfo.Controls.Add(label1);
            gbInfo.Location = new Point(6, 3);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(314, 75);
            gbInfo.TabIndex = 13;
            gbInfo.TabStop = false;
            gbInfo.Text = "Info";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 434);
            Controls.Add(btnConnect);
            Controls.Add(gbInfo);
            Controls.Add(gbChat);
            Name = "ClientForm";
            Text = "ClientForm";
            gbChat.ResumeLayout(false);
            gbChat.PerformLayout();
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbIP;
        private Button btnConnect;
        private TextBox tbName;
        private ListView lsvMessage;
        private Label label1;
        private Label label2;
        private Button btnSend;
        private TextBox tbMessage;
        private GroupBox gbChat;
        private GroupBox gbInfo;
    }
}