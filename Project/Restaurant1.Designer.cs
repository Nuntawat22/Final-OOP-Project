namespace Project
{
    partial class Restaurant1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restaurant1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            CustomerNumber = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Day = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Seat = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            tbName = new TextBox();
            tbNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            button5 = new Button();
            button6 = new Button();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            tbTable = new TextBox();
            label5 = new Label();
            button1 = new Button();
            tbMail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox2 = new GroupBox();
            checkBox16 = new CheckBox();
            checkBox15 = new CheckBox();
            checkBox14 = new CheckBox();
            checkBox13 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox12 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox9 = new CheckBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1263, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LemonChiffon;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, CustomerNumber, Email, Day, Time, Seat });
            dataGridView1.Location = new Point(500, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(640, 243);
            dataGridView1.TabIndex = 1;
            // 
            // Name
            // 
            Name.HeaderText = "ชื่อ";
            Name.Name = "Name";
            // 
            // CustomerNumber
            // 
            CustomerNumber.HeaderText = "เบอร์ลูกค้า";
            CustomerNumber.Name = "CustomerNumber";
            // 
            // Email
            // 
            Email.HeaderText = "อีเมล";
            Email.Name = "Email";
            // 
            // Day
            // 
            Day.HeaderText = "วันที่";
            Day.Name = "Day";
            // 
            // Time
            // 
            Time.HeaderText = "เวลา";
            Time.Name = "Time";
            // 
            // Seat
            // 
            Seat.HeaderText = "โต๊ะอาหาร";
            Seat.Name = "Seat";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(148, 167);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(184, 23);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.Value = new DateTime(2023, 4, 6, 13, 0, 0, 0);
            // 
            // tbName
            // 
            tbName.Location = new Point(148, 49);
            tbName.Name = "tbName";
            tbName.Size = new Size(184, 23);
            tbName.TabIndex = 7;
            // 
            // tbNumber
            // 
            tbNumber.Location = new Point(148, 88);
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(184, 23);
            tbNumber.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 47);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 9;
            label1.Text = "ชื่อ :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 86);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 10;
            label2.Text = "เบอร์โทรลูกค้า :";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSeaGreen;
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(tbTable);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(tbMail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbNumber);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 400);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "โปรดกรอกข้อมูล";
            // 
            // button5
            // 
            button5.BackColor = Color.Firebrick;
            button5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(257, 328);
            button5.Name = "button5";
            button5.Size = new Size(75, 59);
            button5.TabIndex = 18;
            button5.Text = "ออกจากโปรแกรม";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Olive;
            button6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(45, 328);
            button6.Name = "button6";
            button6.Size = new Size(75, 59);
            button6.TabIndex = 17;
            button6.Text = "ลบ 1 ตาราง";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkOrange;
            button4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(148, 328);
            button4.Name = "button4";
            button4.Size = new Size(75, 59);
            button4.TabIndex = 16;
            button4.Text = "รายการอาหาร";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 255);
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(148, 252);
            button2.Name = "button2";
            button2.Size = new Size(75, 59);
            button2.TabIndex = 13;
            button2.Text = "เช็คเอาท์";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(257, 252);
            button3.Name = "button3";
            button3.Size = new Size(75, 59);
            button3.TabIndex = 14;
            button3.Text = " ล้าง";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // tbTable
            // 
            tbTable.Location = new Point(148, 205);
            tbTable.Name = "tbTable";
            tbTable.Size = new Size(184, 23);
            tbTable.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(45, 126);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 14;
            label5.Text = "อีเมล :";
            // 
            // button1
            // 
            button1.BackColor = Color.Chartreuse;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(45, 252);
            button1.Name = "button1";
            button1.Size = new Size(75, 59);
            button1.TabIndex = 12;
            button1.Text = "เช็คอิน";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbMail
            // 
            tbMail.Location = new Point(148, 128);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(184, 23);
            tbMail.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(45, 208);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 12;
            label4.Text = "เลือกที่นั่ง :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightGoldenrodYellow;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(45, 175);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 3;
            label3.Text = "เวลา";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.RosyBrown;
            groupBox2.Controls.Add(checkBox16);
            groupBox2.Controls.Add(checkBox15);
            groupBox2.Controls.Add(checkBox14);
            groupBox2.Controls.Add(checkBox13);
            groupBox2.Controls.Add(checkBox6);
            groupBox2.Controls.Add(checkBox12);
            groupBox2.Controls.Add(checkBox11);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(checkBox8);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox7);
            groupBox2.Controls.Add(checkBox10);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox9);
            groupBox2.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(500, 303);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(661, 217);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "โต๊ะอาหาร";
            // 
            // checkBox16
            // 
            checkBox16.AutoSize = true;
            checkBox16.Location = new Point(466, 172);
            checkBox16.Name = "checkBox16";
            checkBox16.Size = new Size(60, 22);
            checkBox16.TabIndex = 27;
            checkBox16.Text = "OT04";
            checkBox16.UseVisualStyleBackColor = true;
            checkBox16.CheckedChanged += checkBox16_CheckedChanged;
            // 
            // checkBox15
            // 
            checkBox15.AutoSize = true;
            checkBox15.Location = new Point(327, 172);
            checkBox15.Name = "checkBox15";
            checkBox15.Size = new Size(60, 22);
            checkBox15.TabIndex = 26;
            checkBox15.Text = "OT03";
            checkBox15.UseVisualStyleBackColor = true;
            checkBox15.CheckedChanged += checkBox15_CheckedChanged;
            // 
            // checkBox14
            // 
            checkBox14.AutoSize = true;
            checkBox14.Location = new Point(191, 172);
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size(60, 22);
            checkBox14.TabIndex = 25;
            checkBox14.Text = "OT02";
            checkBox14.UseVisualStyleBackColor = true;
            checkBox14.CheckedChanged += checkBox14_CheckedChanged;
            // 
            // checkBox13
            // 
            checkBox13.AutoSize = true;
            checkBox13.Location = new Point(44, 172);
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size(60, 22);
            checkBox13.TabIndex = 24;
            checkBox13.Text = "OT01";
            checkBox13.UseVisualStyleBackColor = true;
            checkBox13.CheckedChanged += checkBox13_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(191, 84);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(61, 22);
            checkBox6.TabIndex = 17;
            checkBox6.Text = "MT02";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point(466, 128);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(59, 22);
            checkBox12.TabIndex = 23;
            checkBox12.Text = "NT04";
            checkBox12.UseVisualStyleBackColor = true;
            checkBox12.CheckedChanged += checkBox12_CheckedChanged;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(327, 128);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(59, 22);
            checkBox11.TabIndex = 22;
            checkBox11.Text = "NT03";
            checkBox11.UseVisualStyleBackColor = true;
            checkBox11.CheckedChanged += checkBox11_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(44, 42);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(56, 22);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "ST01";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(466, 84);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(61, 22);
            checkBox8.TabIndex = 19;
            checkBox8.Text = "MT04";
            checkBox8.UseVisualStyleBackColor = true;
            checkBox8.CheckedChanged += checkBox8_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(191, 42);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(56, 22);
            checkBox2.TabIndex = 13;
            checkBox2.Text = "ST02";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(327, 84);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(61, 22);
            checkBox7.TabIndex = 18;
            checkBox7.Text = "MT03";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(191, 128);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(59, 22);
            checkBox10.TabIndex = 21;
            checkBox10.Text = "NT02";
            checkBox10.UseVisualStyleBackColor = true;
            checkBox10.CheckedChanged += checkBox10_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(466, 42);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(56, 22);
            checkBox4.TabIndex = 15;
            checkBox4.Text = "ST04";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(44, 84);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(61, 22);
            checkBox5.TabIndex = 16;
            checkBox5.Text = "MT01";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(327, 42);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(56, 22);
            checkBox3.TabIndex = 14;
            checkBox3.Text = "ST03";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(44, 128);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(59, 22);
            checkBox9.TabIndex = 20;
            checkBox9.Text = "NT01";
            checkBox9.UseVisualStyleBackColor = true;
            checkBox9.CheckedChanged += checkBox9_CheckedChanged;
            // 
            // Restaurant1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1263, 609);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Text = "Restaurant";
            Load += Restaurant1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private TextBox tbName;
        private TextBox tbNumber;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private Label label5;
        private TextBox tbMail;
        private Label label4;
        private Label label3;
        private TextBox tbTable;
        private Button button2;
        private Button button3;
        private Button button1;
        private Button button4;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn CustomerNumber;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Seat;
        private GroupBox groupBox2;
        private CheckBox checkBox16;
        private CheckBox checkBox15;
        private CheckBox checkBox14;
        private CheckBox checkBox13;
        private CheckBox checkBox6;
        private CheckBox checkBox12;
        private CheckBox checkBox11;
        private CheckBox checkBox1;
        private CheckBox checkBox8;
        private CheckBox checkBox2;
        private CheckBox checkBox7;
        private CheckBox checkBox10;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox3;
        private CheckBox checkBox9;
        private Button button5;
        private Button button6;
    }
}