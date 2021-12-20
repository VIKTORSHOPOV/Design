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

namespace Books
{
    public partial class Form1 : Form
    {
        List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book newBook = new Book
            {
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Year = int.Parse(txtYear.Text),
                Count = int.Parse(txtCount.Text),
                Price = double.Parse(txtPrice.Text)
            };
            books.Add(newBook);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"Books.txt"))
            {
                File.Delete(@"Books.txt");
            }
            using (StreamWriter sw = new StreamWriter(@"Books.txt"))
            {
                string result = string.Empty;
                foreach (Book book in books)
                {
                    result += $"{book.Title} {book.Author} {book.Year} {book.Count} {book.Price} {book.Price * book.Count}lv.\n";
                }
                sw.WriteLine(result);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"Books.txt"))
            {
                using (StreamReader sr = new StreamReader(@"Books.txt"))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
            }
            else
            {
                richTextBox1.Text = "File Missing";
            }
        }

        private void txtYear_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtYear.Text) || int.Parse(txtYear.Text) < 0)
            {
                errorProvider1.SetError(txtYear, "Not a positive number");
            }
            else
            {
                errorProvider1.SetError(txtYear, null);
            }
        }

        private void txtCount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCount.Text) || int.Parse(txtCount.Text) < 0)
            {
                errorProvider1.SetError(txtCount, "Not a positive number");
            }
            else
            {
                errorProvider1.SetError(txtCount, null);
            }
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrice.Text) || double.Parse(txtPrice.Text) < 0)
            {
                errorProvider1.SetError(txtPrice, "Not a positive number");
            }
            else
            {
                errorProvider1.SetError(txtPrice, null);
            }
        }
    }
}
