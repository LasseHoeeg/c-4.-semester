using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion02
{
    internal class Fibonacci
    {



        public static int fib(int n)
        {
            int[] array = new int[n];
            int result = 0;
            if (n <= 1)
            {
                result = n;
            }
            else
            {
                result = fib(n - 1) + fib(n - 2);
             
            }
            return result;
        }

        public static void fibo(int n)
        {
            int[] results = new int[n];
            for(int i = 0; i < n; i++)
            {
                if (i == 0) { 
                
                    Console.WriteLine(i);
                }
                else
                {
                    results[i] = results[i-1] + results[i-2];
                    Console.WriteLine(results[i]);
                }
            }
        }

        public static int[] fiboArray(int n)
        {
            int[] results = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i < 2) { 
               
                    results[i] = i;
                }
                else
                {
                    results[i] = results[i - 1] + results[i - 2];
                }
            }
            return results;
        }




    }


}
