using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classResults
{
    public partial class Form1 : Form
    {
        Student[] classOf = new Student[26];
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 26; i++)
            {
                classOf[i] = new Student();
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            double average = Math.Round((double.Parse(txtBEL.Text) +
                double.Parse(txtEzik.Text) + double.Parse(txtMatematika.Text) + double.Parse(txtFizika.Text) +
                double.Parse(txtHimiq.Text) + double.Parse(txtBiologiq.Text)) / 6, 2);
            lblAverage.Text = average.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClass.Text = ""; txtNumber.Text = ""; txtName.Text = "";
            txtBEL.Text = ""; txtEzik.Text = ""; txtMatematika.Text = "";
            txtFizika.Text = ""; txtHimiq.Text = ""; txtBiologiq.Text = "";
            lblAverage.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtNumber.Text);
            if (i >= 1 && i <= 26)
            {
                txtClass.Text = classOf[i - 1].Clas;
                txtName.Text = classOf[i - 1].Name;
                txtBEL.Text = classOf[i - 1].Bel.ToString();
                txtEzik.Text = classOf[i - 1].Ezik.ToString();
                txtMatematika.Text = classOf[i - 1].Matematika.ToString();
                txtFizika.Text = classOf[i - 1].Fizika.ToString();
                txtBiologiq.Text = classOf[i - 1].Biologia.ToString();
                txtHimiq.Text = classOf[i - 1].Himiq.ToString();


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student newStud = new Student();
            newStud.Id = int.Parse(txtNumber.Text);
            if (newStud.Id >= 1 && newStud.Id <= 26)
            {
                newStud.Clas = txtClass.Text;
                newStud.Name = txtName.Text;
                newStud.Bel = double.Parse(txtBEL.Text);
                newStud.Ezik = double.Parse(txtEzik.Text);
                newStud.Matematika = double.Parse(txtMatematika.Text);
                newStud.Fizika = double.Parse(txtFizika.Text);
                newStud.Biologia = double.Parse(txtBiologiq.Text);
                newStud.Himiq = double.Parse(txtHimiq.Text);
                newStud.Average = Math.Round((double.Parse(txtBEL.Text) +
                double.Parse(txtEzik.Text) + double.Parse(txtMatematika.Text) + double.Parse(txtFizika.Text) +
                double.Parse(txtHimiq.Text) + double.Parse(txtBiologiq.Text)) / 6, 2);

            }
            classOf[newStud.Id - 1] = newStud;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"c:\temp\Results.txt"))
            {
                File.Delete(@"c:\temp\Results.txt");
            }

            using (StreamWriter sw = new StreamWriter(@"c:\temp\Results.txt"))
            {
                foreach (Student stud in classOf)
                {
                    sw.Write(stud.Name + " ");
                    sw.Write(stud.Clas + " ");
                    sw.Write("№" + stud.Id + " ");
                    sw.Write(stud.Bel + " ");
                    sw.Write(stud.Ezik + " ");
                    sw.Write(stud.Matematika + " ");
                    sw.Write(stud.Fizika + " ");
                    sw.Write(stud.Himiq + " ");
                    sw.Write(stud.Biologia + " ");
                    sw.Write(stud.Average + " ");
                    sw.WriteLine();

                }
            }


        }
    }
}
