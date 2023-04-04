using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Restaurant : Form
    {
        public Restaurant()
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


            if (tbName.Text != "TEST" || tbPassword.Text != "1234")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง");
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
    }
}
