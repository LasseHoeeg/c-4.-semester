using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse4._6
{
    internal class Person 
    {
        public int age { get; set; }
        public string name { get; set; }
        public int weight { get; set; }


        public Person(int age, string name, int weight) {
            this.age = age;
            this.name = name;
            this.weight = weight;
        }

        public string ToString()
        {
            return "Alder: " + age + ", navn: " + name + ", vægt: " + weight;
        }

    }
}
