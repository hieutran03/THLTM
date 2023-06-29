namespace Lab5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            rtbBody = new RichTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbSubject = new TextBox();
            tbTo = new TextBox();
            tbFrom = new TextBox();
            label5 = new Label();
            tbPassword = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(348, 346);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rtbBody
            // 
            rtbBody.Location = new Point(89, 133);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(334, 207);
            rtbBody.TabIndex = 11;
            rtbBody.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 133);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 7;
            label4.Text = "Body";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 104);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 8;
            label3.Text = "Subject";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 75);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 9;
            label2.Text = "To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 17);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 10;
            label1.Text = "From";
            // 
            // tbSubject
            // 
            tbSubject.Location = new Point(89, 96);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(334, 23);
            tbSubject.TabIndex = 4;
            // 
            // tbTo
            // 
            tbTo.Location = new Point(89, 67);
            tbTo.Name = "tbTo";
            tbTo.Size = new Size(334, 23);
            tbTo.TabIndex = 5;
            // 
            // tbFrom
            // 
            tbFrom.Location = new Point(89, 9);
            tbFrom.Name = "tbFrom";
            tbFrom.Size = new Size(334, 23);
            tbFrom.TabIndex = 6;
            tbFrom.Text = "hieumdg@gmail.com";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 46);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 14;
            label5.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(89, 38);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(334, 23);
            tbPassword.TabIndex = 13;
            tbPassword.Text = "fqxsmndiswhdvnow";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 400);
            Controls.Add(label5);
            Controls.Add(tbPassword);
            Controls.Add(button1);
            Controls.Add(rtbBody);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbSubject);
            Controls.Add(tbTo);
            Controls.Add(tbFrom);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox rtbBody;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbSubject;
        private TextBox tbTo;
        private TextBox tbFrom;
        private Label label5;
        private TextBox tbPassword;
    }
}