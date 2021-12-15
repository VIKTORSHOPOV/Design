using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_Visit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //List<int> allBytes = new List<int>();
        int sum = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Visit v = new Visit();
            v.Date = textBox1.Text;
            v.Clock = textBox2.Text;
            v.Day = int.Parse(textBox3.Text);
            v.Bytes = int.Parse(textBox4.Text);
            v.Seconds = int.Parse(textBox5.Text);
            v.Web = textBox6.Text;
            sum += v.Bytes;
            //allBytes.Add(v.Bytes);

            listBox1.Items.Add(v.InfoForVisit());
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            //lblData.Text = allBytes.Sum().ToString() + " B";
            lblData.Text = sum.ToString() + " B";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
    }
}
