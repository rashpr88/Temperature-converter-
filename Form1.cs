using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void r2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void r1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void t1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (! Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true ;
            }
        }

        private void t2_TextChanged(object sender, EventArgs e)
        {

        }

        private void t2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void r1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (r1.Checked == true)
            {
                if (t1.Text != "")
                {
                    double temp = Convert.ToDouble(t1.Text);
                    double res ;
                    res = ((9.0 / 5.0) * temp) + 32.0;
                    t2.Text = res.ToString();

                }
                else
                {
                    MessageBox.Show("Please enter a value for temperature");
                }
            }
            else if (r2.Checked == true)
            {
                if (t2.Text != "")
                {
                    double temp = Convert.ToDouble(t2.Text);
                    double res;
                    res = (temp - 32.0) * (5.0 / 9.0);
                    t1.Text = Convert.ToString(res);

                }
                else
                {
                    MessageBox.Show("Please enter a value for temperature");
                }
            }
            else if (t2.Text == "" && t1.Text == "")
            {
                MessageBox.Show("Please enter a value for temperature first and select the conversion");
            }

            else
            {
                MessageBox.Show("Please select a convesion type");
            }

        }
    }
}
