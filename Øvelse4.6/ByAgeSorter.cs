using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse4._6
{
    internal class ByAgeSorter : IComparer<Person>
    {


        public int Compare(Person x, Person y)
        {

            if (x.age.CompareTo(y.age) != 0)
            {
                return x.age.CompareTo(y.age);
            }
            else
            {
                return 0;
            }

        }
    }
}
