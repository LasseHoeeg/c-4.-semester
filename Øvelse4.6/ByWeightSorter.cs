using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse4._6
{
    internal class ByWeightSorter : IComparer<Person>
    {


        public int Compare(Person x, Person y)
        {
            if (x.weight.CompareTo(y.weight) != 0) {
                return x.weight.CompareTo(y.weight);
            }
            else { 
                return 0;
        }

        }
    }
}
