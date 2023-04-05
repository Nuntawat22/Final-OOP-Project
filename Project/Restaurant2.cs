using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Restaurant2 : Form
    {

        public Restaurant2()
        {
            InitializeComponent();
        }
        Checkpay discount = new Checkpay();
        Buy seleManagement = new Buy();

        double a1, a2, a3, a4, b1, b2, b3, b4, num1, num2, num3, num4, alltotal;

        private void button1_Click(object sender, EventArgs e)
        {
            Restaurant1 restaurant = new Restaurant1();
            restaurant.Show();
        }

        private void Discount_Click(object sender, EventArgs e)
        {
            string totaldiscount = this.textBox10.Text;
            double Discount = Convert.ToDouble(totaldiscount);
            discount.create(Discount);

            double totalDiscount = discount.getDiscount();
            textBox9.Text = totalDiscount.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string restaurant = this.textBox9.Text;
            string getmoney = this.textBox11.Text;

            double Restaurant = Convert.ToDouble(restaurant);
            double GetMoney = Convert.ToDouble(getmoney);
            seleManagement.Bill(Restaurant, GetMoney);
            double Totalpay = seleManagement.restaurantBill();
            textBox13.Text = Totalpay.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a1 = 0;
            a2 = 0;
            a3 = 0;
            a4 = 0;


            textBox1.Text = numericUpDown1.Value.ToString();
            textBox2.Text = numericUpDown2.Value.ToString();
            textBox3.Text = numericUpDown3.Value.ToString();
            textBox4.Text = numericUpDown4.Value.ToString();


            if (checkBox1.Checked)
            {
                b1 = double.Parse(textBox1.Text);
                a1 = 79;
                num1 = b1 * a1;
            }
            else
            {
                b1 = double.Parse(textBox1.Text);
                a1 = 79;
                num1 = b1 * a1;
            }

            if (checkBox2.Checked)
            {
                b2 = double.Parse(textBox2.Text);
                a2 = 69;
                num2 = b2 * a2;
            }
            else
            {
                b2 = double.Parse(textBox2.Text);
                a2 = 79;
                num2 = b2 * a2;
            }

            if (checkBox3.Checked)
            {
                b3 = double.Parse(textBox3.Text);
                a3 = 59;
                num3 = b3 * a3;
            }
            else
            {
                b3 = double.Parse(textBox3.Text);
                a3 = 59;
                num3 = b3 * a3;
            }

            if (checkBox4.Checked)
            {
                b4 = double.Parse(textBox4.Text);
                a4 = 59;
                num4 = b4 * a4;
            }
            else
            {
                b4 = double.Parse(textBox4.Text);
                a4 = 59;
                num4 = b4 * a4;
            }
            alltotal = num1 + num2 + num3 + num4;
            textBox9.Text = alltotal.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                numericUpDown1.Enabled = true;
            }
            else
            {
                numericUpDown1.Value = 1;
                numericUpDown1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                numericUpDown2.Enabled = true;
            }
            else
            {
                numericUpDown2.Value = 1;
                numericUpDown2.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                numericUpDown3.Enabled = true;
            }
            else
            {
                numericUpDown3.Value = 1;
                numericUpDown3.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                numericUpDown4.Enabled = true;
            }
            else
            {
                numericUpDown4.Value = 1;
                numericUpDown4.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox9.Clear();
            textBox11.Clear();
            textBox13.Clear();
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
        }


    }
}
