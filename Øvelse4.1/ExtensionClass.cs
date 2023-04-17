using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Øvelse 4.1
//Lav en extension metode Lang() til String, der returnerer true,
//hvis længden af pågældende String er over 5, ellers false.   Test i en main metode.
//Tilret, så metoden Lang tager en parameter n (int), som erstatter 5 (altså returner true, hvis længden er over n)

namespace Øvelse4._1
{
    public static class ExtenstionClass
    {
        public static bool Lang(this string str)
        //public string Lang(this string str, int n)
        {
            bool overN = false;
            if (str.Length > 5)
            //if (str.Length > n)
            {
                overN = true;
            }
            else
            {
                overN = false;
            }
            return overN;
        }

    }
}