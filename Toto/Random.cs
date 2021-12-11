using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    class Rand
    {


        public string GetRandomNumber()
        {

            Random random = new Random();

            return random.Next(1, 50).ToString();

        }
        public int GetRandomNumber2()
        {

            Random random = new Random();

            return random.Next(random.Next(1, 5), random.Next(5, 10));

        }
    }
}
