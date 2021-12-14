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
            student.Import(int.Parse(txtClass.Text), int.Parse(txtNumber.Text), txtName.Text, double.Parse(txtBEL.Text), double.Parse(txtEzik.Text), double.Parse(txtMatematika.Text), double.Parse(txtFizika.Text), double.Parse(txtHimiq.Text), double.Parse(txtBiologiq.Text));
        }

        private void btnSearch_Click(object sender, EventArgs e)
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

        private void btnAverage_Click(object sender, EventArgs e)
        {
            lblAverage.Text = Math.Round((double.Parse(txtBEL.Text) + double.Parse(txtEzik.Text) + double.Parse(txtMatematika.Text) + double.Parse(txtFizika.Text)
                + double.Parse(txtHimiq.Text) + double.Parse(txtBiologiq.Text)) / 6, 2).ToString();
        }
    }
}
