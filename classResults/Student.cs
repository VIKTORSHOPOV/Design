using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classResults
{
    internal class Student
    {
        public string Name { set; get; }
        public int Id { set; get; }
        public string Clas { set; get; }
        public double Bel { set; get; }
        public double Fizika { set; get; }
        public double Biologia { set; get; }
        public double Ezik { set; get; }
        public double Matematika { set; get; }
        public double Himiq { set; get; }
        public double Average { set; get; }

        public Student()
        {
            Name = "Name";
            Id = 0;
            Clas = "Class";
            Bel = 0;
            Fizika = 0;
            Biologia = 0;
            Ezik = 0;
            Matematika = 0;
            Himiq = 0;
            Average = 0;

        }
    }
}
