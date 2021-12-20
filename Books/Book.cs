using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class Book
    {

        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public int Year { get; set; } = 0;
        public int Count { get; set; } = 0;
        public double Price { get; set; } = 0;
        public Book()
        {
        }

        
    }
}
