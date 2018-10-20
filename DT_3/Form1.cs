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
            //          vI, kI, zI, M, aI
            new Pirkejas(3, 2, 4, true, 0),
            new Pirkejas(0, 2, 2, false, 3),
            new Pirkejas(3, 3, 0, true, 4),
            new Pirkejas(1, 2, 2, true, 2),
            new Pirkejas(3, 1, 1, false, 4),
            new Pirkejas(3, 2, 3, true, 2),
            new Pirkejas(0, 0, 4, true, 2),
            new Pirkejas(1, 0, 4, false, 2),
            new Pirkejas(3, 2, 2, true, 3),
            new Pirkejas(2, 1, 1, false, 1),
        };

        public Form1()
        {
            InitializeComponent();
        }

        int comboboxi1, comboboxi2, comboboxi3, comboboxi4, comboboxi5, maitinimas;
        private void button1_Click(object sender, EventArgs e)
        {
            List<int> viList = new List<int>();
            List<int> kiList = new List<int>();
            List<int> ziList = new List<int>();
            List<bool> mList = new List<bool>();
            List<int> aiList = new List<int>();
            foreach (Pirkejas p in pirkejai)
            {
                viList.Add(p.vIndex);
                kiList.Add(p.kIndex);
                ziList.Add(p.zIndex);
                mList.Add(p.maitinimas);
                aiList.Add(p.aIndex);
            }
            int mostVI = viList.GroupBy(i => i).OrderByDescending(grp => grp.Count())
                .Select(grp => grp.Key).First();

            int mostKI = kiList.GroupBy(i => i).OrderByDescending(grp => grp.Count())
                .Select(grp => grp.Key).First();

            int mostZI = ziList.GroupBy(i => i).OrderByDescending(grp => grp.Count())
                .Select(grp => grp.Key).First();

            bool mostM = mList.GroupBy(i => i).OrderByDescending(grp => grp.Count())
                .Select(grp => grp.Key).First();
            if (mostM == true)
            {
                maitinimas = 1;
            }
            else
            {
                maitinimas = 0;
            }


            int mostAI = aiList.GroupBy(i => i).OrderByDescending(grp => grp.Count())
                .Select(grp => grp.Key).First();

            if ((comboboxi1 + 1 == mostVI || comboboxi1 ==mostVI) && (comboboxi2 + 1 == mostKI || comboboxi2 == mostKI) && (comboboxi3 + 1 == mostZI || comboboxi3 == mostZI)
                && comboboxi4 == maitinimas && (comboboxi5 + 1 == mostAI || comboboxi5 == mostAI))
            {
                label4.Text = "Pirks";
                //MessageBox.Show("Pirkėjas užsisakys apartamentus");
            }
            else
            {
                label4.Text = "Nepirks";
                //MessageBox.Show("Pirkėjas aparatamentų neužsisakinės");
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

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxi4 = comboBox4.SelectedIndex;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxi5 = comboBox5.SelectedIndex;
        }
    }
}
