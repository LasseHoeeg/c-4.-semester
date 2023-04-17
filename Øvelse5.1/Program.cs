// See https://aka.ms/new-console-template for more information

internal class Program
{

    
static void Main(string[] args)
{
    List<int> list = new List<int>();   
        list.Add(1);
        list.Add(2);
        list.Add(33);
        list.Add(14);
        list.Add(5);
        list.Add(16);
        list.Add(17);
        list.Add(8);

        Console.WriteLine("Øvelse 5.1");
        //Øvelse 5.1
        List<int> resultsLige = list.FindAll(i => i % 2 == 0);
        //foreach (int i in resultsLige)
        //{
        //    Console.WriteLine(i);
        //}
        resultsLige.ForEach(i => Console.WriteLine(i));

        Console.WriteLine(list.FindLast(i => i > 15));
        Console.WriteLine(list.FindLastIndex(i => i > 15));

        Console.WriteLine("Øvelse 5.2");

        //Øvelse 5.2

        //IEnumerable<int> resultater = list.Where(i => i % 2 == 0);
        IEnumerable<int> resultater = list.Where(i => i % 2 == 0).OrderBy(i => i);
        foreach(int i in resultater)
        {
            Console.WriteLine(i);
        }

        //IEnumerable<int> resultaterLig2 = list.Where(i => i.ToString().Length == 2);
        IEnumerable<int> resultaterLig2 = list.Where(i => i.ToString().Length== 2).OrderBy(i => i);



        foreach (int i in resultaterLig2)
        {
            Console.WriteLine(i);
        }





    }



}
