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
    }
}
