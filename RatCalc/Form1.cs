using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatCalc
{
    public partial class Form1 : Form
    {
        static int gcd(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }

        public int isWhole()
        {
            int br = 0;
            List<char> elements = new List<char>();
            foreach (char el1 in txtFirstNumber.Text)
            {
                elements.Add(el1);
            }
            foreach (char el2 in txtSecondNumber.Text)
            {
                elements.Add(el2);
            }
            foreach (char el in elements)
            {
                if (el == '/')
                {
                    br++;
                }
            }
            if (br == 2)
            {
                return 1;
            }
            else if (br == 1)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isWhole() == 1)
            {
                string number1 = txtFirstNumber.Text;
                string[] numbers1 = number1.Split('/');
                string number2 = txtSecondNumber.Text;
                string[] numbers2 = number2.Split('/');

                int c1 = int.Parse(numbers1[0]);
                int c2 = int.Parse(numbers2[0]);
                int z1 = int.Parse(numbers1[1]);
                int z2 = int.Parse(numbers2[1]);

                int min = int.MaxValue;
                for (int i = 1; i <= z1 * z2; i++)
                {
                    if (i % z1 == 0 && i % z2 == 0)
                    {
                        if (i < min)
                        {
                            min = i;
                        }
                    }
                }

                int result1 = c1 * (min / z1);
                int result2 = c2 * (min / z2);
                lblResult.Text = ((result1 + result2) / gcd(result1, result2)).ToString() + '/' + (min / gcd(result1, result2)).ToString();
            }
            else if (isWhole() == 0)
            {
                lblResult.Text = (int.Parse(txtFirstNumber.Text) + int.Parse(txtSecondNumber.Text)).ToString();
            }
            else
            {
                if (txtFirstNumber.Text.ToCharArray().Contains('/'))
                {
                    txtSecondNumber.Text += "/1";
                }
                else
                {
                    txtFirstNumber.Text += "/1";
                }

                string number1 = txtFirstNumber.Text;
                string[] numbers1 = number1.Split('/');
                string number2 = txtSecondNumber.Text;
                string[] numbers2 = number2.Split('/');

                int c1 = int.Parse(numbers1[0]);
                int c2 = int.Parse(numbers2[0]);
                int z1 = int.Parse(numbers1[1]);
                int z2 = int.Parse(numbers2[1]);

                int min = int.MaxValue;
                for (int i = 1; i <= z1 * z2; i++)
                {
                    if (i % z1 == 0 && i % z2 == 0)
                    {
                        if (i < min)
                        {
                            min = i;
                        }
                    }
                }

                int result1 = c1 * (min / z1);
                int result2 = c2 * (min / z2);
                lblResult.Text = ((result1 + result2) / gcd(result1, result2)).ToString() + '/' + (min / gcd(result1, result2)).ToString();

            }
        }

        private void txtFirstNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
            lblResult.Text = "";
            txtFirstNumber.Focus();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (isWhole() == 1)
            {
                string number1 = txtFirstNumber.Text;
                string[] numbers1 = number1.Split('/');
                string number2 = txtSecondNumber.Text;
                string[] numbers2 = number2.Split('/');

                int c1 = int.Parse(numbers1[0]);
                int c2 = int.Parse(numbers2[0]);
                int z1 = int.Parse(numbers1[1]);
                int z2 = int.Parse(numbers2[1]);

                int min = int.MaxValue;
                for (int i = 1; i <= z1 * z2; i++)
                {
                    if (i % z1 == 0 && i % z2 == 0)
                    {
                        if (i < min)
                        {
                            min = i;
                        }
                    }
                }

                int result1 = c1 * (min / z1);
                int result2 = c2 * (min / z2);
                lblResult.Text = ((result1 - result2) / gcd(result1, result2)).ToString() + '/' + (min / gcd(result1, result2)).ToString();
            }
            else if (isWhole() == 0)
            {
                lblResult.Text = (int.Parse(txtFirstNumber.Text) - int.Parse(txtSecondNumber.Text)).ToString();
            }
            else
            {
                if (txtFirstNumber.Text.ToCharArray().Contains('/'))
                {
                    txtSecondNumber.Text += "/1";
                }
                else
                {
                    txtFirstNumber.Text += "/1";
                }

                string number1 = txtFirstNumber.Text;
                string[] numbers1 = number1.Split('/');
                string number2 = txtSecondNumber.Text;
                string[] numbers2 = number2.Split('/');

                int c1 = int.Parse(numbers1[0]);
                int c2 = int.Parse(numbers2[0]);
                int z1 = int.Parse(numbers1[1]);
                int z2 = int.Parse(numbers2[1]);

                int min = int.MaxValue;
                for (int i = 1; i <= z1 * z2; i++)
                {
                    if (i % z1 == 0 && i % z2 == 0)
                    {
                        if (i < min)
                        {
                            min = i;
                        }
                    }
                }

                int result1 = c1 * (min / z1);
                int result2 = c2 * (min / z2);
                lblResult.Text = ((result1 - result2) / gcd(result1, result2)).ToString() + '/' + (min / gcd(result1, result2)).ToString();
            }


        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (isWhole() == 1)
            {
                string number1 = txtFirstNumber.Text;
                string[] numbers1 = number1.Split('/');
                string number2 = txtSecondNumber.Text;
                string[] numbers2 = number2.Split('/');

                int c1 = int.Parse(numbers1[0]);
                int c2 = int.Parse(numbers2[0]);
                int z1 = int.Parse(numbers1[1]);
                int z2 = int.Parse(numbers2[1]);


                int result1 = c1 * c2;
                int result2 = z1 * z2;
                lblResult.Text = (result1 / gcd(result1, result2)).ToString() + '/' + (result2 / gcd(result1, result2)).ToString();
            }
            else if (isWhole() == 0)
            {
                lblResult.Text = (int.Parse(txtFirstNumber.Text) * int.Parse(txtSecondNumber.Text)).ToString();
            }
            else
            {
                if (txtFirstNumber.Text.ToCharArray().Contains('/'))
                {
                    txtSecondNumber.Text += "/1";
                }
                else
                {
                    txtFirstNumber.Text += "/1";
                }

                string number1 = txtFirstNumber.Text;
                string[] numbers1 = number1.Split('/');
                string number2 = txtSecondNumber.Text;
                string[] numbers2 = number2.Split('/');

                int c1 = int.Parse(numbers1[0]);
                int c2 = int.Parse(numbers2[0]);
                int z1 = int.Parse(numbers1[1]);
                int z2 = int.Parse(numbers2[1]);


                int result1 = c1 * c2;
                int result2 = z1 * z2;
                lblResult.Text = (result1 / gcd(result1, result2)).ToString() + '/' + (result2 / gcd(result1, result2)).ToString();

            }
        }

        private void btnDev_Click(object sender, EventArgs e)
        {
            if (isWhole() == 1)
            {
                string number1 = txtFirstNumber.Text;
                string[] numbers1 = number1.Split('/');
                string number2 = txtSecondNumber.Text;
                string[] numbers2 = number2.Split('/');

                int c1 = int.Parse(numbers1[0]);
                int c2 = int.Parse(numbers2[0]);
                int z1 = int.Parse(numbers1[1]);
                int z2 = int.Parse(numbers2[1]);


                int result1 = c1 * z2;
                int result2 = z1 * c2;
                lblResult.Text = (result1 / gcd(result1, result2)).ToString() + '/' + (result2 / gcd(result1, result2)).ToString();
            }
            else if (isWhole() == 0)
            {
                lblResult.Text = (int.Parse(txtFirstNumber.Text) / (double)int.Parse(txtSecondNumber.Text)).ToString();
            }
            else
            {
                if (txtFirstNumber.Text.ToCharArray().Contains('/'))
                {
                    txtSecondNumber.Text += "/1";
                }
                else
                {
                    txtFirstNumber.Text += "/1";
                }

                string number1 = txtFirstNumber.Text;
                string[] numbers1 = number1.Split('/');
                string number2 = txtSecondNumber.Text;
                string[] numbers2 = number2.Split('/');

                int c1 = int.Parse(numbers1[0]);
                int c2 = int.Parse(numbers2[0]);
                int z1 = int.Parse(numbers1[1]);
                int z2 = int.Parse(numbers2[1]);


                int result1 = c1 * z2;
                int result2 = z1 * c2;
                lblResult.Text = (result1 / gcd(result1, result2)).ToString() + '/' + (result2 / gcd(result1, result2)).ToString();

            }
        }
    }
}
