using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DT_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int comboboxi1, comboboxi2, comboboxi3, comboboxi4, comboboxi5;
        double k1, k2,k3,k4,k5, kb;

        private void button1_Click(object sender, EventArgs e)
        {
            if (k1 != 0 && k2 != 0 && k3 != 0 && k4 != 0 && k5 != 0)
            {
                kb = k1 + k2 + k3 + k4 + k5;
                if (kb > 12)
                {
                    label4.Text = "Verta\n";// + "Koeficientas: " + kb;
                }
                else
                {
                    label4.Text = "Neverta\n";// + "Koeficientas: " + kb;
                }
            }
            else
            {
                MessageBox.Show("Kažko nepasirinkote!");
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            k1 = 0;
            comboboxi1 = comboBox1.SelectedIndex;
            if (comboboxi1 == 0)
            {
                k1 += 1;
            }
            else if (comboboxi1 == 1)
            {
                k1 += 2;
            }

            else if (comboboxi1 == 2)
            {
                k1 += 3;
            }
            else if (comboboxi1 == 3)
            {
                k1 += 4;
            }
        }
    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            k2 = 0;
            comboboxi2 = comboBox2.SelectedIndex;
            if (comboboxi2 == 0)
            {
                k2 += 4;
            }
            else if (comboboxi2 == 1)
            {
                k2 += 3;
            }

            else if (comboboxi2 == 2)
            {
                k2 += 2;
            }
            else if (comboboxi2 == 3)
            {
                k2 += 1;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            k3 = 0;
            comboboxi3 = comboBox3.SelectedIndex;
            if (comboboxi3 == 0)
            {
                k3 += 1;
            }
            else if (comboboxi3 == 1)
            {
                k3 += 2;
            }

            else if (comboboxi3 == 2)
            {
                k3 += 3;
            }
            else if (comboboxi3 == 3)
            {
                k3 += 4;
            }
            else if (comboboxi3 == 4)
            {
                k3 += 5;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            k4 = 0;
            comboboxi4 = comboBox4.SelectedIndex;
            if (comboboxi4 == 0)
            {
                k4 += 2;
            }
            else if (comboboxi4 == 1)
            {
                k4 += 1;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            k5 = 0;
            comboboxi5 = comboBox5.SelectedIndex;
            if (comboboxi5 == 0)
            {
                k5 += 6;
            }
            else if (comboboxi5 == 1)
            {
                k5 += 5;
            }

            else if (comboboxi5 == 2)
            {
                k5 += 4;
            }
            else if (comboboxi5 == 3)
            {
                k5 += 3;
            }
            else if (comboboxi5 == 4)
            {
                k5 += 2;
            }
            else if (comboboxi5 == 5)
            {
                k5 += 1;
            }
        }
    }
}
