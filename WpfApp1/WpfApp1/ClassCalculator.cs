using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class ClassCalculator
    {

        public float Plus(string a, string b)
        {
            return float.Parse(a) + float.Parse(b);
        }
        public float Minus(string a, string b)
        {
            return float.Parse(a) - float.Parse(b);
        }
        public float Multiplication(string a, string b)
        {
            return float.Parse(a) * float.Parse(b);
        }
        public float Division(string a, string b)
        {
            if(b  == "0")
            {
                return 0;
            }
            return float.Parse(a) / float.Parse(b);
        }

    }
}
