namespace Project
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
            tbName = new TextBox();
            tbPassword = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(104, 31);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(104, 71);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(100, 23);
            tbPassword.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(26, 116);
            button1.Name = "button1";
            button1.Size = new Size(75, 53);
            button1.TabIndex = 2;
            button1.Text = "ตกลง";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(118, 116);
            button2.Name = "button2";
            button2.Size = new Size(75, 53);
            button2.TabIndex = 3;
            button2.Text = "ออกจากโปรแกรม";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 35);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 4;
            label1.Text = "ชื่อผู้ใช้งาน :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 74);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 5;
            label2.Text = "รหัสผ่าน :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbPassword);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(84, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 193);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "เข้าสู่ระบบ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(410, 344);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Restaurant";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbName;
        private TextBox tbPassword;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
    }
}