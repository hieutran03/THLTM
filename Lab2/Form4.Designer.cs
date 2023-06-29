namespace Lab2
{
    partial class Form4
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
            tbNameIn = new TextBox();
            tbPhoneIn = new TextBox();
            tbIDIn = new TextBox();
            tbCourse1In = new TextBox();
            tbCourse2In = new TextBox();
            tbCourse3In = new TextBox();
            tbAverageIn = new TextBox();
            listBox1 = new ListBox();
            tbAverageOut = new TextBox();
            tbCourse3Out = new TextBox();
            tbCourse2Out = new TextBox();
            tbCourse1Out = new TextBox();
            tbIDOut = new TextBox();
            tbPhoneOut = new TextBox();
            tbNameOut = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            btnWriteFile = new Button();
            btnReadFile = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            lbIndex = new Label();
            SuspendLayout();
            // 
            // tbNameIn
            // 
            tbNameIn.Location = new Point(12, 56);
            tbNameIn.Name = "tbNameIn";
            tbNameIn.Size = new Size(145, 23);
            tbNameIn.TabIndex = 0;
            // 
            // tbPhoneIn
            // 
            tbPhoneIn.Location = new Point(12, 148);
            tbPhoneIn.Name = "tbPhoneIn";
            tbPhoneIn.Size = new Size(145, 23);
            tbPhoneIn.TabIndex = 1;
            // 
            // tbIDIn
            // 
            tbIDIn.Location = new Point(12, 102);
            tbIDIn.Name = "tbIDIn";
            tbIDIn.Size = new Size(145, 23);
            tbIDIn.TabIndex = 2;
            // 
            // tbCourse1In
            // 
            tbCourse1In.Location = new Point(12, 194);
            tbCourse1In.Name = "tbCourse1In";
            tbCourse1In.Size = new Size(145, 23);
            tbCourse1In.TabIndex = 3;
            tbCourse1In.TextChanged += tbCourse1In_TextChanged;
            // 
            // tbCourse2In
            // 
            tbCourse2In.Location = new Point(12, 238);
            tbCourse2In.Name = "tbCourse2In";
            tbCourse2In.Size = new Size(145, 23);
            tbCourse2In.TabIndex = 4;
            tbCourse2In.TextChanged += tbCourse2In_TextChanged;
            // 
            // tbCourse3In
            // 
            tbCourse3In.Location = new Point(12, 282);
            tbCourse3In.Name = "tbCourse3In";
            tbCourse3In.Size = new Size(145, 23);
            tbCourse3In.TabIndex = 5;
            tbCourse3In.TextChanged += tbCourse3In_TextChanged;
            // 
            // tbAverageIn
            // 
            tbAverageIn.BackColor = SystemColors.ButtonHighlight;
            tbAverageIn.Location = new Point(12, 328);
            tbAverageIn.Name = "tbAverageIn";
            tbAverageIn.ReadOnly = true;
            tbAverageIn.Size = new Size(145, 23);
            tbAverageIn.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(222, 51);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(307, 289);
            listBox1.TabIndex = 14;
            // 
            // tbAverageOut
            // 
            tbAverageOut.BackColor = SystemColors.ButtonHighlight;
            tbAverageOut.Location = new Point(597, 323);
            tbAverageOut.Name = "tbAverageOut";
            tbAverageOut.ReadOnly = true;
            tbAverageOut.Size = new Size(145, 23);
            tbAverageOut.TabIndex = 21;
            // 
            // tbCourse3Out
            // 
            tbCourse3Out.BackColor = SystemColors.ButtonHighlight;
            tbCourse3Out.Location = new Point(597, 277);
            tbCourse3Out.Name = "tbCourse3Out";
            tbCourse3Out.ReadOnly = true;
            tbCourse3Out.Size = new Size(145, 23);
            tbCourse3Out.TabIndex = 20;
            // 
            // tbCourse2Out
            // 
            tbCourse2Out.BackColor = SystemColors.ButtonHighlight;
            tbCourse2Out.Location = new Point(597, 233);
            tbCourse2Out.Name = "tbCourse2Out";
            tbCourse2Out.ReadOnly = true;
            tbCourse2Out.Size = new Size(145, 23);
            tbCourse2Out.TabIndex = 19;
            // 
            // tbCourse1Out
            // 
            tbCourse1Out.BackColor = SystemColors.ButtonHighlight;
            tbCourse1Out.Location = new Point(597, 189);
            tbCourse1Out.Name = "tbCourse1Out";
            tbCourse1Out.ReadOnly = true;
            tbCourse1Out.Size = new Size(145, 23);
            tbCourse1Out.TabIndex = 18;
            // 
            // tbIDOut
            // 
            tbIDOut.BackColor = SystemColors.ButtonHighlight;
            tbIDOut.Location = new Point(597, 97);
            tbIDOut.Name = "tbIDOut";
            tbIDOut.ReadOnly = true;
            tbIDOut.Size = new Size(145, 23);
            tbIDOut.TabIndex = 17;
            // 
            // tbPhoneOut
            // 
            tbPhoneOut.BackColor = SystemColors.ButtonHighlight;
            tbPhoneOut.Location = new Point(597, 143);
            tbPhoneOut.Name = "tbPhoneOut";
            tbPhoneOut.ReadOnly = true;
            tbPhoneOut.Size = new Size(145, 23);
            tbPhoneOut.TabIndex = 16;
            // 
            // tbNameOut
            // 
            tbNameOut.BackColor = SystemColors.ButtonHighlight;
            tbNameOut.Location = new Point(597, 51);
            tbNameOut.Name = "tbNameOut";
            tbNameOut.ReadOnly = true;
            tbNameOut.Size = new Size(145, 23);
            tbNameOut.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 336);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 35;
            label1.Text = "Average";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 285);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 34;
            label2.Text = "Course 3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 241);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 33;
            label3.Text = "Course 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 197);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 32;
            label4.Text = "Course 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(163, 151);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 31;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(163, 105);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 30;
            label6.Text = "ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(163, 59);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 29;
            label7.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(535, 331);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 42;
            label8.Text = "Average";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(535, 280);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 41;
            label9.Text = "Course 3";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(535, 236);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 40;
            label10.Text = "Course 2";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(535, 192);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 39;
            label11.Text = "Course 1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(535, 146);
            label12.Name = "label12";
            label12.Size = new Size(41, 15);
            label12.TabIndex = 38;
            label12.Text = "Phone";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(535, 100);
            label13.Name = "label13";
            label13.Size = new Size(18, 15);
            label13.TabIndex = 37;
            label13.Text = "ID";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(535, 54);
            label14.Name = "label14";
            label14.Size = new Size(39, 15);
            label14.TabIndex = 36;
            label14.Text = "Name";
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(12, 12);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(147, 23);
            btnWriteFile.TabIndex = 43;
            btnWriteFile.Text = "Write to a file";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(595, 12);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(147, 23);
            btnReadFile.TabIndex = 44;
            btnReadFile.Text = "Read a file";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // button3
            // 
            button3.Location = new Point(43, 368);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 45;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(589, 377);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 46;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(689, 377);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 47;
            button5.Text = "Next";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // lbIndex
            // 
            lbIndex.AutoSize = true;
            lbIndex.Location = new Point(670, 381);
            lbIndex.Name = "lbIndex";
            lbIndex.Size = new Size(13, 15);
            lbIndex.TabIndex = 48;
            lbIndex.Text = "1";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbIndex);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnReadFile);
            Controls.Add(btnWriteFile);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(tbAverageOut);
            Controls.Add(tbCourse3Out);
            Controls.Add(tbCourse2Out);
            Controls.Add(tbCourse1Out);
            Controls.Add(tbIDOut);
            Controls.Add(tbPhoneOut);
            Controls.Add(tbNameOut);
            Controls.Add(listBox1);
            Controls.Add(tbAverageIn);
            Controls.Add(tbCourse3In);
            Controls.Add(tbCourse2In);
            Controls.Add(tbCourse1In);
            Controls.Add(tbIDIn);
            Controls.Add(tbPhoneIn);
            Controls.Add(tbNameIn);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNameIn;
        private TextBox tbPhoneIn;
        private TextBox tbIDIn;
        private TextBox tbCourse1In;
        private TextBox tbCourse2In;
        private TextBox tbCourse3In;
        private TextBox tbAverageIn;
        private ListBox listBox1;
        private TextBox tbAverageOut;
        private TextBox tbCourse3Out;
        private TextBox tbCourse2Out;
        private TextBox tbCourse1Out;
        private TextBox tbIDOut;
        private TextBox tbPhoneOut;
        private TextBox tbNameOut;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button btnWriteFile;
        private Button btnReadFile;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label lbIndex;
    }
}