using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse4._6
{
    internal class ByNameSorter : IComparer<Person>
    {


        public int Compare(Person x, Person y)
        {
            if (x.name.CompareTo(y.name) != 0)
            {
                return x.name.CompareTo(y.name);
            } 
            else
            {
                return 0;
            }
        }
    }
}
