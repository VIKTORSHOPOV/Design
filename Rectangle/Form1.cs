using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangle
{
    public partial class Rectangle : Form
    {
        public Rectangle()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            Rec rec = new Rec();
            if (txtHeight.Text == "")
            {
                txtHeight.Text = 0.ToString();
            }
            if (txtWidth.Text == "")
            {
                txtWidth.Text = 0.ToString();
            }
            lblArea.Text = rec.Area(double.Parse(txtWidth.Text), double.Parse(txtHeight.Text));
        }

        private void btnPerimeter_Click(object sender, EventArgs e)
        {
            Rec rec = new Rec();
            if(txtHeight.Text == "")
            {
                txtHeight.Text = 0.ToString();
            }
            if (txtWidth.Text == "")
            {
                txtWidth.Text = 0.ToString();
            }
            lblPerimeter.Text = rec.Perimeter(double.Parse(txtWidth.Text), double.Parse(txtHeight.Text));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWidth.Clear();
            txtHeight.Clear();
            lblArea.Text = "";
            lblPerimeter.Text = "";
            txtWidth.Focus();
        }
    }


}
