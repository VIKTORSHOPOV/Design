using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toto
{
    public partial class Form1 : Form
    {
        int br1;
        int br2;
        int br3;
        int br4;
        int br5;
        int br6;
        public Form1()
        {
            InitializeComponent();

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            timer5.Enabled = true;
            timer6.Enabled = true;
            br1 = 0;
            br2 = 0;
            br3 = 0;
            br4 = 0;
            br5 = 0;
            br6 = 0;
            button.Visible = false;
        }

        public void Timer1_Tick(object sender, EventArgs e)
        {

            Rand r = new Rand();
            lbl1.Text = r.GetRandomNumber();
            br1++;
            if (br1 == 10)
            {
                timer1.Enabled = false;
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Rand r = new Rand();
            lbl2.Text = r.GetRandomNumber();
            br2++;
            if (lbl2.Text == lbl1.Text)
            {
                br2 -= r.GetRandomNumber2();
            }
            if (br2 == 20)
            {
                timer2.Enabled = false;
            }
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            Rand r = new Rand();
            lbl3.Text = r.GetRandomNumber();
            br3++;
            if (lbl3.Text == lbl1.Text || lbl3.Text == lbl2.Text)
            {
                br3 -= r.GetRandomNumber2();
            }
            if (br3 == 30)
            {
                timer3.Enabled = false;
            }
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            Rand r = new Rand();
            lbl4.Text = r.GetRandomNumber();
            br4++;
            if (lbl4.Text == lbl1.Text || lbl4.Text == lbl2.Text || lbl4.Text == lbl3.Text)
            {
                br4 -= r.GetRandomNumber2();
            }
            if (br4 == 40)
            {
                timer4.Enabled = false;
            }
        }

        private void Timer5_Tick(object sender, EventArgs e)
        {
            Rand r = new Rand();
            lbl5.Text = r.GetRandomNumber();
            br5++;
            if (lbl5.Text == lbl1.Text || lbl5.Text == lbl2.Text || lbl5.Text == lbl3.Text || lbl5.Text == lbl4.Text)
            {
                br5 -= r.GetRandomNumber2();
            }
            if (br5 == 50)
            {
                timer5.Enabled = false;
            }
        }

        private void Timer6_Tick(object sender, EventArgs e)
        {
            Rand r = new Rand();
            lbl6.Text = r.GetRandomNumber();
            br6++;
            if (lbl6.Text == lbl1.Text || lbl6.Text == lbl2.Text || lbl6.Text == lbl3.Text || lbl6.Text == lbl4.Text || lbl6.Text == lbl5.Text)
            {
                br6 -= r.GetRandomNumber2();
            }
            if (br6 == 60)
            {
                timer6.Enabled = false;
            }
        }
        bool flag = true;
        private void timer7_Tick(object sender, EventArgs e)
        {
            if (timer6.Enabled == false)
            {
                button.Visible = true;
            }
            if (timer6.Enabled == true)
            {
                if (flag)
                {
                    BackColor = Color.DeepPink;
                    flag = false;
                }
                else
                {
                    BackColor = Color.MediumPurple;
                    flag = true;
                }
            }
            else
            {
                BackColor = Color.Pink;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
