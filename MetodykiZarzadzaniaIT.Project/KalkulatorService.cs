using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodykiZarzadzaniaIT.Project
{
    public static  class KalkulatorService
    {
        public static double Add(double first, double second)
        {
            return  first + second;
        }

        public static double Odd(double first, double second)
        {
            return first - second;
        }

        public static double Divide(double first, double second)
        {
            return first / second;
        }

        public static double Multiply(double first, double second)
        {
            return first * second;
        }
    }
}
