using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usporednik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            var radians = Math.PI * int.Parse(txtAngle.Text) / 180.0;
            var sin = Math.Round(Math.Sin(radians), 2);
            lbl1.Text = (double.Parse(txtA.Text) * double.Parse(txtB.Text) * sin).ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            var radians = Math.PI * int.Parse(txtAngle.Text) / 180.0;
            var sin = Math.Round(Math.Sin(radians), 2);
            lbl2.Text = ((double.Parse(txtD1.Text) * double.Parse(txtD2.Text) * sin) / 2).ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            var a = double.Parse(txtA.Text);
            var b = double.Parse(txtB.Text);
            var c = double.Parse(txtC.Text);
            var p = (a + b + c) / 2;
            var S_tri = Math.Sqrt(p * (p - a) * (p - b) * (p - c))*2;
            var S_trap = 4 * S_tri;
            lbl3.Text = S_tri.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtD1.Clear();
            txtD2.Clear();
            txtAngle.Clear();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            var a = double.Parse(txtA.Text);
            var b = double.Parse(txtB.Text);
            var radians = Math.PI * int.Parse(txtAngle.Text) / 180.0;
            var cos = Math.Round(Math.Cos(radians), 2);
            var d1_2ndpower = Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * cos;
            var d1 = Math.Sqrt(d1_2ndpower);
            txtD1.Text = d1.ToString();
            
            var radians2 = Math.PI * (180 - int.Parse(txtAngle.Text)) / 180.0;
            var cos2 = Math.Round(Math.Cos(radians2), 2);
            var d2_2ndpower = Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * cos2;
            var d2 = Math.Sqrt(d2_2ndpower);
            txtD2.Text = d2.ToString();

        }
    }
}
