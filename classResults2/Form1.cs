using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace classResults2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"c:\temp\Results.txt"))
            {
                using (StreamReader sr = new StreamReader(@"c:\temp\Results.txt"))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
            }
            else
            {
                richTextBox1.Text = "File Missing";
            }


        }
    }
}
