namespace Lab5
{
    partial class Send_mail
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
            btnSend = new Button();
            rtbBody = new RichTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbSubject = new TextBox();
            tbTo = new TextBox();
            tbFrom = new TextBox();
            label5 = new Label();
            tbAttachment = new TextBox();
            btnBrowse = new Button();
            cbHTML = new CheckBox();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(363, 380);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 23;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // rtbBody
            // 
            rtbBody.Location = new Point(84, 124);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(334, 207);
            rtbBody.TabIndex = 22;
            rtbBody.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 98);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 18;
            label4.Text = "Body";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 73);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 19;
            label3.Text = "Subject";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 44);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 20;
            label2.Text = "To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 21;
            label1.Text = "From";
            // 
            // tbSubject
            // 
            tbSubject.Location = new Point(84, 65);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(334, 23);
            tbSubject.TabIndex = 15;
            // 
            // tbTo
            // 
            tbTo.Location = new Point(84, 36);
            tbTo.Name = "tbTo";
            tbTo.Size = new Size(334, 23);
            tbTo.TabIndex = 16;
            // 
            // tbFrom
            // 
            tbFrom.Location = new Point(84, 7);
            tbFrom.Name = "tbFrom";
            tbFrom.ReadOnly = true;
            tbFrom.Size = new Size(334, 23);
            tbFrom.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 354);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 24;
            label5.Text = "Attachment";
            // 
            // tbAttachment
            // 
            tbAttachment.Location = new Point(84, 351);
            tbAttachment.Name = "tbAttachment";
            tbAttachment.Size = new Size(273, 23);
            tbAttachment.TabIndex = 25;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(363, 351);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 26;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // cbHTML
            // 
            cbHTML.AutoSize = true;
            cbHTML.Location = new Point(84, 97);
            cbHTML.Name = "cbHTML";
            cbHTML.Size = new Size(58, 19);
            cbHTML.TabIndex = 27;
            cbHTML.Text = "HTML";
            cbHTML.UseVisualStyleBackColor = true;
            // 
            // Send_mail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 405);
            Controls.Add(cbHTML);
            Controls.Add(btnBrowse);
            Controls.Add(tbAttachment);
            Controls.Add(label5);
            Controls.Add(btnSend);
            Controls.Add(rtbBody);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbSubject);
            Controls.Add(tbTo);
            Controls.Add(tbFrom);
            Name = "Send_mail";
            Text = "Send_mail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private RichTextBox rtbBody;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbSubject;
        private TextBox tbTo;
        private TextBox tbFrom;
        private Label label5;
        private TextBox tbAttachment;
        private Button btnBrowse;
        private CheckBox cbHTML;
    }
}