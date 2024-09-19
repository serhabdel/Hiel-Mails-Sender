namespace Hiel_Mails_Sender
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            progressBar1 = new ProgressBar();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button3 = new Button();
            panel2 = new Panel();
            label7 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label8 = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F);
            textBox1.Location = new Point(209, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(493, 26);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 12F);
            textBox2.Location = new Point(209, 229);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(493, 26);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 12F);
            textBox3.Location = new Point(209, 264);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(493, 230);
            textBox3.TabIndex = 2;
            textBox3.WordWrap = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(104, 152);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 3;
            label1.Text = "Sender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(104, 230);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 4;
            label2.Text = "Receiver";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(104, 265);
            label3.Name = "label3";
            label3.Size = new Size(45, 21);
            label3.TabIndex = 5;
            label3.Text = "Body";
            // 
            // button1
            // 
            button1.Location = new Point(414, 537);
            button1.Name = "button1";
            button1.Size = new Size(68, 25);
            button1.TabIndex = 6;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSendEmail_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(113, 568);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(648, 23);
            progressBar1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Gmail", "Outlook" });
            comboBox1.Location = new Point(140, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 23);
            comboBox1.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 12F);
            textBox4.Location = new Point(140, 39);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(309, 26);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Times New Roman", 12F);
            textBox5.Location = new Point(140, 80);
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '*';
            textBox5.Size = new Size(309, 26);
            textBox5.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(44, 8);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 11;
            label4.Text = "Provider";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(44, 40);
            label5.Name = "label5";
            label5.Size = new Size(54, 21);
            label5.TabIndex = 12;
            label5.Text = "E-mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(26, 80);
            label6.Name = "label6";
            label6.Size = new Size(108, 21);
            label6.TabIndex = 13;
            label6.Text = "App Password";
            // 
            // button3
            // 
            button3.Font = new Font("Tahoma", 15F, FontStyle.Bold);
            button3.Location = new Point(545, 27);
            button3.Name = "button3";
            button3.Size = new Size(129, 53);
            button3.TabIndex = 14;
            button3.Text = "Log In";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(78, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(682, 122);
            panel2.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(105, 184);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 17;
            label7.Text = "Subject";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Times New Roman", 12F);
            textBox6.Location = new Point(209, 184);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(493, 26);
            textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Times New Roman", 12F);
            textBox7.Location = new Point(378, 500);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(246, 26);
            textBox7.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(271, 501);
            label8.Name = "label8";
            label8.Size = new Size(97, 21);
            label8.TabIndex = 20;
            label8.Text = "Attachments";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 601);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hiel Mails Sender";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private ProgressBar progressBar1;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button3;
        private Panel panel2;
        private Label label7;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label8;
        private OpenFileDialog openFileDialog1;
    }
}
