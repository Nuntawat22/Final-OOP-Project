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
                MessageBox.Show("��سҡ�͡Username");
                tbName.Focus();
            }

            else if (tbPassword.Text == "")
            {
                MessageBox.Show("��سҡ�͡Password");
                tbPassword.Focus();
            }

            
            if (tbName.Text != "TEST" || tbPassword.Text != "1234")
            {
                MessageBox.Show("��سҡ�͡User���Password���١��ͧ");
                tbName.Focus();
                tbPassword.Focus();
            }

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