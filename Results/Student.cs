using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Results
{
    class Student
    {
        int[] aklas = new int[26];
        int[] anumber = new int[26];
        string[] aname = new string[26];
        double[] abel = new double[26];
        double[] aezik = new double[26];
        double[] amatematika = new double[26];
        double[] afizika = new double[26];
        double[] ahimiq = new double[26];
        double[] abiologiq = new double[26];

        public void Import(int klas, int number, string name, double bel, double ezik, double matematika, double fizika, double himiq, double biologiq)
        {
            aklas[number - 1] = klas;
            anumber[number - 1] = number;
            aname[number - 1] = name;
            abel[number - 1] = bel;
            aezik[number - 1] = ezik;
            amatematika[number - 1] = matematika;
            afizika[number - 1] = fizika;
            ahimiq[number - 1] = himiq;
            abiologiq[number - 1] = biologiq;

        }

        public double[] Find(string name)
        {
            int index = -1;
            for (int i = 0; i < aname.Length; i++)
            {
                if (aname[i] == name)
                {
                    index = i;
                    break;
                }
            }

            double[] output = new double[8];
            output[0] = aklas[index];
            output[1] = anumber[index];
            output[2] = abel[index];
            output[3] = aezik[index];
            output[4] = amatematika[index];
            output[5] = afizika[index];
            output[6] = ahimiq[index];
            output[7] = abiologiq[index];

            return output;

        }
    }
}
