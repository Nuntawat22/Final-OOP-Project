namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("กรุณากรอก Username");
                tbName.Focus();
            }

            else if (tbPassword.Text == "")
            {
                MessageBox.Show("กรุณากรอก Password");
                tbPassword.Focus();
            }

            // คำสั่งใส่รหัสผ่านผิด/ถูก
            if (tbName.Text != "TEST" || tbPassword.Text != "1234")
            {
                MessageBox.Show("กรุณากรอก User Name และ Password ให้ถูกต้อง");
                tbName.Focus();
                tbPassword.Focus();
            }

            // ใช้ else เพื่อเปิดให้เป็น Form ต่อไป
            else
            {
                this.Hide();
                Restaurant1 restaurant = new Restaurant1();
                restaurant.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}