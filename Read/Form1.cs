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

namespace Read
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pos, next;
            Students newStud = new Students();
            StreamReader r = new StreamReader("clasFile.txt");
            Encoding.GetEncoding("Unicode");
            string line = r.ReadLine(); line += "";
            pos = 0; next = line.IndexOf("", pos);
            Name = line.Substring(pos, next - pos);
            pos = next + 1; next = line.IndexOf("");
            newStud.clas = line.Substring(pos, next - pos);
            pos = next + 1; next = line.IndexOf("");
            newStud.id = line.Substring(pos, next - pos);
            pos = next + 1; next = line.IndexOf("", pos);
            int pos1 = next + 1; next = line.IndexOf("", pos1);
            newStud.Name = line.Substring(pos1, next - pos);
            pos = next + 1; next = line.IndexOf("");
            newStud.Dbel = double.Parse(line.Substring(pos, next - pos));
            richTextBox1.Text += "С П Р А В К А" + "\n";
            richTextBox1.Text += "за успеха на " + newStud.Name + "\n";
            richTextBox1.Text += newStud.clas
                + "клас,номер" + newStud.id + "/n";
            richTextBox1.Text += "БЕЛ   -" + newStud.Dbel + "\n";
            richTextBox1.Text += "Чужд език _" + newStud.Dforeign + "\n";
            richTextBox1.Text += "Математика _" + newStud.Dmath + "\n";
            richTextBox1.Text += "Физика _" + newStud.Dfizika + "\n";
            richTextBox1.Text += "Химия _" + newStud.Dhimiq + "\n";
            richTextBox1.Text += "Биология _" + newStud.Dbio + "\n";
            richTextBox1.Text += "Среден успех _" + newStud.Average() + "\n";

        }
    }
}
