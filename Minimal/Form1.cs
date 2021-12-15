using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimal
{
    public partial class Form1 : Form
    {
        int min;
        public Form1()
        {
            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            listBox1.Items.Clear();
            min = int.MaxValue;
            for (int i = 0; i < 10; i++)
            {
                int number = r.Next(1, 101);
                listBox1.Items.Add(number);
                if (number < min)
                {
                    min = number;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = min.ToString();
        }
    }
}
