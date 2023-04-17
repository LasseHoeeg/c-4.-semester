// See https://aka.ms/new-console-template for more information
using Øvelse4._6;



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


foreach(Person p in list)
{
    Console.WriteLine(p.ToString());
}
Console.WriteLine();
list.Sort(new ByWeightSorter());

foreach (Person p in list)
{
    Console.WriteLine(p.ToString());
}

Console.WriteLine();
list.Sort(new ByNameSorter()); //Fungerer ikke

foreach (Person p in list)
{
    Console.WriteLine(p.ToString());
}

Console.WriteLine();
list.Sort(new ByAgeSorter());

foreach (Person p in list)
{
    Console.WriteLine(p.ToString());
}