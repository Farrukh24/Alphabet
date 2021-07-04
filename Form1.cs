using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alphabet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3();
            b.Show();
            button3.Enabled = true;
        }

          private void button3_Click(object sender, EventArgs e)
        {
            Form5 c = new Form5();
            c.Show();
            button4.Enabled = true;
        }
          private void button4_Click(object sender, EventArgs e)
        {
           Form4 d = new Form4();
            d.Show();
            button5.Enabled = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 e_letter = new Form6();
            e_letter.Show();
            button6.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.Show();
            button12.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form8 g = new Form8();
            g.Show();
            button11.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form9 h = new Form9();
            h.Show();
            button10.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form10 i = new Form10();
            i.Show();
            button9.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form11 j = new Form11();
            j.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form12 k = new Form12();
            k.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form13 l = new Form13();
            l.Show();
        }
    }
}
