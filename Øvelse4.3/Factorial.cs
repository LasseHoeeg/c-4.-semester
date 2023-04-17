using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse4._3
{
    internal static class Factorial
    {



        public static int factorial(this int n)
        {
            int result = 0;
            if (n == 0)
            {
                result = 1;
            }
            else
            {

                result = n * factorial(n - 1);
            }
            return result;
        }

        public static int power(this int n, int p)
        {
            int result = 0;
            if (p == 0)
            {
                result = 1;
            }
            else
            {
                result = n * power(n, p - 1);
            }
            return result;
        }

    }
}
