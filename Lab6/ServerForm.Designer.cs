namespace Lab6
{
    partial class ServerForm
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
            btnListen = new Button();
            tbIP = new TextBox();
            lsvMessage = new ListView();
            SuspendLayout();
            // 
            // btnListen
            // 
            btnListen.Location = new Point(239, 23);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(75, 23);
            btnListen.TabIndex = 1;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // tbIP
            // 
            tbIP.Location = new Point(12, 23);
            tbIP.Name = "tbIP";
            tbIP.ReadOnly = true;
            tbIP.Size = new Size(221, 23);
            tbIP.TabIndex = 2;
            tbIP.TextAlign = HorizontalAlignment.Center;
            // 
            // lsvMessage
            // 
            lsvMessage.Location = new Point(12, 64);
            lsvMessage.Name = "lsvMessage";
            lsvMessage.Size = new Size(302, 265);
            lsvMessage.TabIndex = 3;
            lsvMessage.UseCompatibleStateImageBehavior = false;
            lsvMessage.View = View.Tile;
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 359);
            Controls.Add(lsvMessage);
            Controls.Add(tbIP);
            Controls.Add(btnListen);
            Name = "ServerForm";
            Text = "ServerForm";
            FormClosing += ServerForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnListen;
        private TextBox tbIP;
        private ListView lsvMessage;
    }
}