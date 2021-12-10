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
            width.Location = new Point(width.Location.X, width.Location.Y - 100);
            txtWidth.Location = new Point(txtWidth.Location.X, txtWidth.Location.Y - 120);
            btnArea.Location = new Point(btnArea.Location.X, btnArea.Location.Y - 140);
            lblArea.Location = new Point(lblArea.Location.X, lblArea.Location.Y - 160);

            btnClear.Location = new Point(btnClear.Location.X + 200, btnClear.Location.Y);

            height.Location = new Point(height.Location.X, height.Location.Y + 100);
            txtHeight.Location = new Point(txtHeight.Location.X, txtHeight.Location.Y + 120);
            btnPerimeter.Location = new Point(btnPerimeter.Location.X, btnPerimeter.Location.Y + 140);
            lblPerimeter.Location = new Point(lblPerimeter.Location.X, lblPerimeter.Location.Y + 160);
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
            if (txtHeight.Text == "")
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (btnClear.Location.X != 613)
            {
                btnClear.Location = new Point(btnClear.Location.X - 1, btnClear.Location.Y);
            }

            if (btnClear.Location.X == 613)
            {
                btnReset.Visible = true;
            }
            else
            {
                btnReset.Visible = false;
            }


            if (btnPerimeter.Location.Y != 65)
            {
                btnPerimeter.Location = new Point(btnPerimeter.Location.X, btnPerimeter.Location.Y - 1);
            }
            if (btnArea.Location.Y != 25)
            {
                btnArea.Location = new Point(btnArea.Location.X, btnArea.Location.Y + 1);
            }
            if (width.Location.Y != 34)
            {
                width.Location = new Point(width.Location.X, width.Location.Y + 1);
            }
            if (txtWidth.Location.Y != 30)
            {
                txtWidth.Location = new Point(txtWidth.Location.X, txtWidth.Location.Y + 1);
            }
            if (height.Location.Y != 74)
            {
                height.Location = new Point(height.Location.X, height.Location.Y - 1);
            }
            if (txtHeight.Location.Y != 70)
            {
                txtHeight.Location = new Point(txtHeight.Location.X, txtHeight.Location.Y - 1);
            }
            if (lblArea.Location.Y != 25)
            {
                lblArea.Location = new Point(lblArea.Location.X, lblArea.Location.Y + 1);
            }
            if (lblPerimeter.Location.Y != 65)
            {
                lblPerimeter.Location = new Point(lblPerimeter.Location.X, lblPerimeter.Location.Y - 1);
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            width.Location = new Point(width.Location.X, width.Location.Y - 100);
            txtWidth.Location = new Point(txtWidth.Location.X, txtWidth.Location.Y - 120);
            btnArea.Location = new Point(btnArea.Location.X, btnArea.Location.Y - 140);
            lblArea.Location = new Point(lblArea.Location.X, lblArea.Location.Y - 160);

            btnClear.Location = new Point(btnClear.Location.X + 200, btnClear.Location.Y);

            height.Location = new Point(height.Location.X, height.Location.Y + 100);
            txtHeight.Location = new Point(txtHeight.Location.X, txtHeight.Location.Y + 120);
            btnPerimeter.Location = new Point(btnPerimeter.Location.X, btnPerimeter.Location.Y + 140);
            lblPerimeter.Location = new Point(lblPerimeter.Location.X, lblPerimeter.Location.Y + 160);
        }
    }


}
