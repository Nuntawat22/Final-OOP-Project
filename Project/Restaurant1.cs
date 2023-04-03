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
    }
}
