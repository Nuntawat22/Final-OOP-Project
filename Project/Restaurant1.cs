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
    public partial class Restaurant1 : Form
    {
        public Restaurant1()
        {
            InitializeComponent();
        }
        // กฟไกฟไกฟไฟไกฟกฟ
        private void button1_Click(object sender, EventArgs e)
        {

            int RT = dataGridView1.Rows.Add();
            dataGridView1.Rows[RT].Cells[0].Value = tbName.Text;
            dataGridView1.Rows[RT].Cells[1].Value = tbNumber.Text;
            dataGridView1.Rows[RT].Cells[2].Value = tbMail.Text;
            dataGridView1.Rows[RT].Cells[3].Value = dateTimePicker1.Text;
            dataGridView1.Rows[RT].Cells[4].Value = label3.Text;
            dataGridView1.Rows[RT].Cells[5].Value = tbTable.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numRows = dataGridView1.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                try
                {
                    int max = dataGridView1.Rows.Count - 1;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[max]);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }



            tbName.Text = "";
            tbNumber.Text = "";
            tbMail.Text = "";
            tbTable.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
                this.Hide();
                Restaurant2 restaurant = new Restaurant2();
                restaurant.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.tbTable.Text = "";
            Control.ControlCollection Controls = groupBox2.Controls;
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked == true)
                    {
                        if (this.tbTable.Text != "")
                            this.tbTable.Text = this.tbTable.Text + ", ";

                        this.tbTable.Text += ((CheckBox)control).Text;
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.tbTable.Text = "";
            Control.ControlCollection Controls = groupBox2.Controls;
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked == true)
                    {
                        if (this.tbTable.Text != "")
                            this.tbTable.Text = this.tbTable.Text + ", ";

                        this.tbTable.Text += ((CheckBox)control).Text;
                    }
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.tbTable.Text = "";
            Control.ControlCollection Controls = groupBox2.Controls;
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked == true)
                    {
                        if (this.tbTable.Text != "")
                            this.tbTable.Text = this.tbTable.Text + ", ";

                        this.tbTable.Text += ((CheckBox)control).Text;
                    }
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            this.tbTable.Text = "";
            Control.ControlCollection Controls = groupBox2.Controls;
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked == true)
                    {
                        if (this.tbTable.Text != "")
                            this.tbTable.Text = this.tbTable.Text + ", ";

                        this.tbTable.Text += ((CheckBox)control).Text;
                    }
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            this.tbTable.Text = "";
            Control.ControlCollection Controls = groupBox2.Controls;
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked == true)
                    {
                        if (this.tbTable.Text != "")
                            this.tbTable.Text = this.tbTable.Text + ", ";

                        this.tbTable.Text += ((CheckBox)control).Text;
                    }
                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            this.tbTable.Text = "";
            Control.ControlCollection Controls = groupBox2.Controls;
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked == true)
                    {
                        if (this.tbTable.Text != "")
                            this.tbTable.Text = this.tbTable.Text + ", ";

                        this.tbTable.Text += ((CheckBox)control).Text;
                    }
                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            this.tbTable.Text = "";
            Control.ControlCollection Controls = groupBox2.Controls;
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked == true)
                    {
                        if (this.tbTable.Text != "")
                            this.tbTable.Text = this.tbTable.Text + ", ";

                        this.tbTable.Text += ((CheckBox)control).Text;
                    }
                }
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            this.tbTable.Text = "";
            Control.ControlCollection Controls = groupBox2.Controls;
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked == true)
                    {
                        if (this.tbTable.Text != "")
                            this.tbTable.Text = this.tbTable.Text + ", ";

                        this.tbTable.Text += ((CheckBox)control).Text;
                    }
                }
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            this.tbTable.Text = "";
            Control.ControlCollection Controls = groupBox2.Controls;
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked == true)
                    {
                        if (this.tbTable.Text != "")
                            this.tbTable.Text = this.tbTable.Text + ", ";

                        this.tbTable.Text += ((CheckBox)control).Text;
                    }
                }
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            this.tbTable.Text = "";
            Control.ControlCollection Controls = groupBox2.Controls;
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked == true)
                    {
                        if (this.tbTable.Text != "")
                            this.tbTable.Text = this.tbTable.Text + ", ";

                        this.tbTable.Text += ((CheckBox)control).Text;
                    }
                }
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            this.tbTable.Text = "";
            Control.ControlCollection Controls = groupBox2.Controls;
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked == true)
                    {
                        if (this.tbTable.Text != "")
                            this.tbTable.Text = this.tbTable.Text + ", ";

                        this.tbTable.Text += ((CheckBox)control).Text;
                    }
                }
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            this.tbTable.Text = "";
            Control.ControlCollection Controls = groupBox2.Controls;
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked == true)
                    {
                        if (this.tbTable.Text != "")
                            this.tbTable.Text = this.tbTable.Text + ", ";

                        this.tbTable.Text += ((CheckBox)control).Text;
                    }
                }
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            this.tbTable.Text = "";
            Control.ControlCollection Controls = groupBox2.Controls;
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked == true)
                    {
                        if (this.tbTable.Text != "")
                            this.tbTable.Text = this.tbTable.Text + ", ";

                        this.tbTable.Text += ((CheckBox)control).Text;
                    }
                }
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            this.tbTable.Text = "";
            Control.ControlCollection Controls = groupBox2.Controls;
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked == true)
                    {
                        if (this.tbTable.Text != "")
                            this.tbTable.Text = this.tbTable.Text + ", ";

                        this.tbTable.Text += ((CheckBox)control).Text;
                    }
                }
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            this.tbTable.Text = "";
            Control.ControlCollection Controls = groupBox2.Controls;
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked == true)
                    {
                        if (this.tbTable.Text != "")
                            this.tbTable.Text = this.tbTable.Text + ", ";

                        this.tbTable.Text += ((CheckBox)control).Text;
                    }
                }
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            this.tbTable.Text = "";
            Control.ControlCollection Controls = groupBox2.Controls;
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked == true)
                    {
                        if (this.tbTable.Text != "")
                            this.tbTable.Text = this.tbTable.Text + ", ";

                        this.tbTable.Text += ((CheckBox)control).Text;
                    }
                }
            }
        }
        private void Restaurant1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortTimeString();
        }


    }
}
