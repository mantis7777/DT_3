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


        List<Pirkejas> pirkejai = new List<Pirkejas>
        {
            //           amzius  issilavinimas  atlyginimas  
            new Pirkejas("Jaunas", "Vidurinis", "Didelis", true),
            new Pirkejas("Vidutinis", "Pagrindinis", "Vidutinis", true),
            new Pirkejas("Jaunas", "Vidurinis", "Mažas", true),
            new Pirkejas("Senas", "Pagrindinis", "Didelis", false),
            new Pirkejas("Vidutinis", "Aukštasis", "Vidutinis", true),
            new Pirkejas("Jaunas", "Pagrindinis", "Didelis", false),
            new Pirkejas("Jaunas", "Vidurinis", "Mažas", true),
            new Pirkejas("Vidutinis", "Aukštasis", "Vidutinis", false),
            new Pirkejas("Jaunas", "Vidurinis", "Mažas", false),
            new Pirkejas("Senas", "Aukštasis", "Didelis", true),
        };

        public Form1()
        {
            InitializeComponent();
            print();
        }
        
        int comboboxi1, comboboxi2, comboboxi3;
        bool BuyOrNot_Age, BuyOrNot_Education, BuyOrNot_Money;
        int answer;
        private void button1_Click(object sender, EventArgs e)
        {
            answer = 0;
            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "")
            {
                checkCustomersAge();
                checkCustomerEducation();
                checkCustomerMoney();
                if (answer >= 2)
                {
                    label4.Text = "Vienuoliktasis pirkėjas nuomosis kambarį.";
                }
                else
                {
                    label4.Text = "Vienuoliktasis pirkėjas kambario nesinomuos.";
                }
                label6.Text = answer.ToString();
            }
            else
            {
                MessageBox.Show("Trūksta duomenų.");
            }
        }
        private void checkCustomersAge()
        {
            List<Pirkejas> pirke_amzius = new List<Pirkejas>();
            List<Pirkejas> Nepirke_amzius = new List<Pirkejas>();
            string age = comboBox1.SelectedItem.ToString();
            foreach (Pirkejas p in pirkejai)
            {
                if (age == p.amzius && p.arPirko == true)
                {
                    pirke_amzius.Add(p);
                }
                else if (age == p.amzius && p.arPirko == false)
                {
                    Nepirke_amzius.Add(p);
                }
            }
            if (pirke_amzius.Count() > Nepirke_amzius.Count())
            {
                BuyOrNot_Age = true;
                answer += 1;
            }
            else
            {
                BuyOrNot_Age = false;
            }
        }

        private void checkCustomerEducation()
        {
            List<Pirkejas> pirke_issilavinimas = new List<Pirkejas>();
            List<Pirkejas> Nepirke_issilavinimas = new List<Pirkejas>();
            string education = comboBox2.SelectedItem.ToString();
            foreach (Pirkejas p in pirkejai)
            {
                if (education == p.issilavinimas && p.arPirko == true)
                {
                    pirke_issilavinimas.Add(p);
                }
                else if (education == p.issilavinimas && p.arPirko == false)
                {
                    Nepirke_issilavinimas.Add(p);
                }
            }
            if (pirke_issilavinimas.Count() > Nepirke_issilavinimas.Count())
            {
                BuyOrNot_Education = true;
                answer += 1;
            }
            else
            {
                BuyOrNot_Education = false;
            }
        }

        private void checkCustomerMoney()
        {
            List<Pirkejas> pirke_atlyginimas = new List<Pirkejas>();
            List<Pirkejas> Nepirke_atlyginimas = new List<Pirkejas>();
            string money = comboBox3.SelectedItem.ToString();
            foreach (Pirkejas p in pirkejai)
            {
                if (money == p.atlyginimas && p.arPirko == true)
                {
                    pirke_atlyginimas.Add(p);
                }
                else if (money == p.atlyginimas && p.arPirko == false)
                {
                    Nepirke_atlyginimas.Add(p);
                }
            }
            if (pirke_atlyginimas.Count() > Nepirke_atlyginimas.Count())
            {
                BuyOrNot_Money = true;
                answer += 1;
            }
            else
            {
                BuyOrNot_Money = false;
            }

        }
        private void print()
        {
            int counter = 1;
            string arpirko = string.Empty;
            listView1.View = View.Details;
            listView1.Columns.Add("Pirkėjo numeris");
            listView1.Columns.Add("Pirkėjo amžius");
            listView1.Columns.Add("Pirkėjo išsilavinimas");
            listView1.Columns.Add("Pirkėjo Atlyginimas");
            listView1.Columns.Add("Ar pirko?");
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            foreach (Pirkejas p in pirkejai)
            {
                if (p.arPirko == true)
                {
                    listView1.Items.Add(new ListViewItem(new string[] { counter.ToString(), p.amzius, p.issilavinimas, p.atlyginimas, "TAIP" }));
                }
                else
                {
                    listView1.Items.Add(new ListViewItem(new string[] { counter.ToString(), p.amzius, p.issilavinimas, p.atlyginimas, "NE" }));
                }
                counter++;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxi1 = comboBox1.SelectedIndex;
        }
    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxi2 = comboBox2.SelectedIndex;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxi3 = comboBox3.SelectedIndex;
        }
    }
}
