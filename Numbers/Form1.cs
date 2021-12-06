using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            switch (txtInput.Text)
            {
                case "0": lblWord.Text = "Нула"; break;
                case "1": lblWord.Text = "Едно"; break;
                case "2": lblWord.Text = "Две"; break;
                case "3": lblWord.Text = "Три"; break;
                case "4": lblWord.Text = "Четири"; break;
                case "5": lblWord.Text = "Пет"; break;
                case "6": lblWord.Text = "Шест"; break;
                case "7": lblWord.Text = "Седем"; break;
                case "8": lblWord.Text = "Осем"; break;
                case "9": lblWord.Text = "Девет"; break;
                default:
                    lblWord.Text = "Не знам";
                    break;
            }
        }
    }
}
