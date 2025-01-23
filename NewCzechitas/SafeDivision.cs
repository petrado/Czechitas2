using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCzechitas
{
    public class SafeDivision
    {
        public double DivideNumbers(double a, double b)
        {
            // if b = 0, result is error
            if (b == 0)
            {
                throw new ArgumentException("Zero division");
                throw new ArgumentException();
            }
            return a / b;
        }
    }
}
