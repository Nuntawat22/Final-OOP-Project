using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Restaurant1 : Form
    {
        List<Restaurant> listRestaurant = new List<Restaurant>();
        Restaurant selectedRestaurant;

        private Stream restaurantFilePath;
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

        private void button2_Click(object sender, EventArgs e)
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

                catch (Exception)
                {
                    MessageBox.Show("ล้างเรียบร้อย");
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

        private void button6_Click(object sender, EventArgs e)
        {



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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void SaveData()
        {
            string path = "data.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {

                        string Name = row.Cells[0].Value.ToString();
                        string CustomerNumber = row.Cells[1].Value.ToString();
                        string Mail = row.Cells[2].Value.ToString();
                        string Day = row.Cells[3].Value.ToString();
                        string Time = row.Cells[4].Value.ToString();
                        string Seat = row.Cells[5].Value.ToString();
                        string line = string.Format("{0},{1},{2},{3},{4},{5}", Name, CustomerNumber, Mail, Day, Time, Seat); ;
                        writer.WriteLine(line);

                    }
                }
            }
        }*/

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV(*.csv)|*csv";
                bool fileError = false;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int columnCount = dataGridView1.Columns.Count;
                        string columnName = "";
                        string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                        for (int i = 0; i < columnCount; i++)
                        {
                            columnName += dataGridView1.Columns[i].HeaderText.ToString() + ",";

                        }
                        for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < columnCount; j++)
                            {
                                outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";

                            }

                        }
                        File.WriteAllLines(saveFileDialog.FileName, outputCSV, Encoding.UTF8);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }
            }
        }
    }
}
