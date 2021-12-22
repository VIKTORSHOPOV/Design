using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class Book
    {

        public string Title { get; set; } = "Title";
        public string Author { get; set; } = "Author";
        public int Year { get; set; } = 0;
        public int Count { get; set; } = 0;
        public double Price { get; set; } = 0.00;
        public Book()
        {
        }

        public string BookInfo()
        {
            return $"{Title} {Author} {Year} {Count} {Price} {Price * Count}lv.\n";
        }


        


    }
}
