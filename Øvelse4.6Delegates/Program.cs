// See https://aka.ms/new-console-template for more information



using Øvelse4._6;
internal class Program
{

    //Har muligvis ikke anvendt delegate
    static public int CompareName(Person x, Person y)
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
    static public int CompareWeight(Person x, Person y)
    {
        if (x.weight.CompareTo(y.weight) != 0)
        {
            return x.weight.CompareTo(y.weight);
        }
        else
        {
            return 0;
        }

    }

    static public int CompareAge(Person x, Person y)
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





    static void Main(string[] args)
    {
        Person p1 = new Person(20, "A", 100);
        Person p2 = new Person(30, "BB", 200);
        Person p3 = new Person(40, "FF", 50);
        Person p4 = new Person(10, "DD", 400);
        Person p5 = new Person(5, "CC", 20);

        List<Person> list = new List<Person>();
        list.Add(p1);
        list.Add(p2);
        list.Add(p3);
        list.Add(p4);
        list.Add(p5);

        foreach (Person p in list)
        {
            Console.WriteLine(p.ToString());
        }
        Console.WriteLine(); 
       // list.Sort(CompareAge);
        list.Sort(CompareWeight); //Får ikke brugt delegate
        //list.Sort(CompareName);


        //Nedenstående er et eks. jeg fandt på nettet.
        //list.Sort(delegate (Person e1, Person e2)
        //{
        //    //Sorting the Employees Based on Name
        //    return e1.name.CompareTo(e2.name);
        //});


        foreach (Person p in list)
        {
            Console.WriteLine(p.ToString());
        }

    }

    }