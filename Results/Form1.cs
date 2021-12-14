using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Results
{
    public partial class Form1 : Form
    {
        Students student = new Students();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(Controls);
            lblAverage.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text != "")
            {
                if (double.Parse(txtNumber.Text) > 26) Close();
                if (double.Parse(txtNumber.Text) < 1) Close();
            }
            else
            {
                Close();
            }
            if (txtBEL.Text != "")
            {
                if (double.Parse(txtBEL.Text) > 6) txtBEL.Text = "6";
                if (double.Parse(txtBEL.Text) < 2) txtBEL.Text = "2";
            }
            else
            {
                txtBEL.Text = "2";
            }
            if (txtEzik.Text != "")
            {
                if (double.Parse(txtEzik.Text) > 6) txtEzik.Text = "6";
                if (double.Parse(txtEzik.Text) < 2) txtEzik.Text = "2";
            }
            else
            {
                txtEzik.Text = "2";
            }
            if (txtMatematika.Text != "")
            {
                if (double.Parse(txtMatematika.Text) > 6) txtMatematika.Text = "6";
                if (double.Parse(txtMatematika.Text) < 2) txtMatematika.Text = "2";
            }
            else
            {
                txtMatematika.Text = "2";
            }
            if (txtFizika.Text != "")
            {
                if (double.Parse(txtFizika.Text) > 6) txtFizika.Text = "6";
                if (double.Parse(txtFizika.Text) < 2) txtFizika.Text = "2";
            }
            else
            {
                txtFizika.Text = "2";
            }
            if (txtHimiq.Text != "")
            {
                if (double.Parse(txtHimiq.Text) > 6) txtHimiq.Text = "6";
                if (double.Parse(txtHimiq.Text) < 2) txtHimiq.Text = "2";
            }
            else
            {
                txtHimiq.Text = "2";
            }
            if (txtBiologiq.Text != "")
            {
                if (double.Parse(txtBiologiq.Text) > 6) txtBiologiq.Text = "6";
                if (double.Parse(txtBiologiq.Text) < 2) txtBiologiq.Text = "2";
            }
            else
            {
                txtBiologiq.Text = "2";
            }
            if (txtClass.Text != "")
            {
                if (double.Parse(txtClass.Text) > 12) txtClass.Text = "12";
                if (double.Parse(txtClass.Text) < 1) txtClass.Text = "1";
            }
            else
            {
                txtClass.Text = "1";
            }
            if(txtName.Text == "")
            {
                txtName.Text = "Default";
            }


            student.Import(int.Parse(txtClass.Text), int.Parse(txtNumber.Text), txtName.Text, double.Parse(txtBEL.Text),
                double.Parse(txtEzik.Text), double.Parse(txtMatematika.Text), double.Parse(txtFizika.Text),
                double.Parse(txtHimiq.Text), double.Parse(txtBiologiq.Text));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (student.Contains(txtName.Text))
            {
                double[] output = student.Find(txtName.Text);
                txtClass.Text = output[0].ToString();
                txtNumber.Text = output[1].ToString();
                txtBEL.Text = output[2].ToString();
                txtEzik.Text = output[3].ToString();
                txtMatematika.Text = output[4].ToString();
                txtFizika.Text = output[5].ToString();
                txtHimiq.Text = output[6].ToString();
                txtBiologiq.Text = output[7].ToString();
            }
            else
            {
                txtClass.Text = "";
                txtNumber.Text = "";
                txtBEL.Text = "";
                txtEzik.Text = "";
                txtMatematika.Text = "";
                txtFizika.Text = "";
                txtHimiq.Text = "";
                txtBiologiq.Text = "";
            }

        }


        private void btnAverage_Click(object sender, EventArgs e)
        {
            if (txtBEL.Text != "" && txtEzik.Text != "" && txtMatematika.Text != "" && txtFizika.Text != "" && txtHimiq.Text != "" && txtBiologiq.Text != "")
            {
                lblAverage.Text = Math.Round((double.Parse(txtBEL.Text) + double.Parse(txtEzik.Text) + double.Parse(txtMatematika.Text) + double.Parse(txtFizika.Text)
                    + double.Parse(txtHimiq.Text) + double.Parse(txtBiologiq.Text)) / 6, 2).ToString();
            }
            else
            {
                lblAverage.Text = "Error";
            }
        }
        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }
    }
}
