using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse4._6
{

    //delegate int CompareDelegate(Person x, Person y);
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

        //public List<Card> filterCardGame(FilterCardDelegate filter)
        //{
        //    List<Card> filterdCards = new List<Card>(); //Der skal tilføjes til listen
        //    foreach (Card card in Cards)
        //    {
        //        if (filter.Invoke(card) == true)
        //        {
        //            filterdCards.Add(card);
        //        }

        //    }


        //    return filterdCards;

        //}

        //public int filterCardGame(CompareDelegate compare)
        //{
        //    compare.Invoke()
        //    return filterdCards;
        //}


        public string ToString()
        {
            return "Alder: " + age + ", navn: " + name + ", vægt: " + weight;
        }

    }
}
