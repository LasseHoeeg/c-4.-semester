
using Microsoft.VisualBasic;
using Øvelse5._3;
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.ConstrainedExecution;

static class Program
{

   static List<Person> people1;


    public static void Exercise1()
    {
        try
        {

            people1 = Person.ReadCSVFile(@"C:\Users\Bruger\Documents\Datamatiker\4. Semester\C# og .Net\data1.csv");

        }
        catch (Exception ex)
        {
            Console.WriteLine("EXCEPTION: " + ex.Message);
            Console.WriteLine("You should probably set the filename to the Person.ReadCSVFile method to something on your disk!");
        }
    }

    public static void SetAcceptedP(this List<Person> list, Predicate<Person> pred)
    {
        list.FindAll(pred).ForEach(person => person.Accepted = true);
    }

    public static void Reset(this List<Person> list)
    {
        list.ForEach(person => person.Accepted = false);
    }

    static void Main(string[] args)
    {
        Exercise1();

        //Øvelse 5.3

        //foreach (Person person in people1) //Print alle
        //{
        //    Console.WriteLine(person.ToString());
        //}

        List<Person> scoreUnder2 = people1.FindAll(person => person.Score < 2);
        List<Person> resultsLige = people1.FindAll(person => person.Score % 2 == 0);
        List<Person> resultsLigeOgOverVægt = people1.FindAll(person => person.Score < 2 && person.Weight > 60);
        List<Person> resultsDeleligtMed3 = people1.FindAll(person => person.Score % 3 == 0 && person.Score > 0);

        //foreach(Person person in scoreUnder2)
        //{
        //    Console.WriteLine(person.ToString());
        //}

        //foreach (Person person in resultsLige)
        //{
        //    Console.WriteLine(person.ToString());
        //}

        //foreach (Person person in resultsLigeOgOverVægt)
        //{
        //    Console.WriteLine(person.ToString());
        //}

        //foreach (Person person in resultsDeleligtMed3)
        //{
        //    Console.WriteLine(person.ToString());
        //}


    

        // ------------------------------------------------------------------------------------------------------------------

        //Øvelse 5.4


        //Console.WriteLine(people1.FindIndex(person => person.Score == 3));

        // Console.WriteLine(people1[13]);
        //   Console.WriteLine(people1.FindIndex(person => person.Score == 3 && person.Age < 10));
        //     Console.WriteLine(people1[52]);

        //List<Person> list = people1.FindAll(person => person.Score == 3 && person.Age < 10);

        //foreach(Person person in list)
        //{
        //    Console.WriteLine(person.ToString());
        //}

        //Console.WriteLine(people1.FindIndex(person => person.Score == 3 && person.Age < 8));
        //Returnerer -1 fordi der ikke er nogen personer med disse betingelser.

        // ------------------------------------------------------------------------------------------------------------------

        //Øvelse5.6
        //people1.SetAcceptedP(p => p.Score >= 6 && p.Age <= 40);
        //List<Person> list = people1.FindAll(p => p.Score >= 6 && p.Age <= 40);
        //foreach (Person person in list)
        //{
        //    Console.WriteLine(person.ToString());
        //}

        // ------------------------------------------------------------------------------------------------------------------

        //Øvelse 5.7
        //  IEnumerable<int> resultater = list.Where(i => i % 2 == 0).OrderBy(i => i);
        //IEnumerable<Person> sorteretStigende = people1.OrderBy(person => person.Score).ThenBy(person => person.Age);
        //foreach(Person person in sorteretStigende)
        //{
        //    Console.WriteLine(person.ToString());
        //}

        //IEnumerable<Person> sorteretFaldende = people1.OrderByDescending(person => person.Score).ThenByDescending(person => person.Age);
        //foreach (Person person in sorteretFaldende)
        //{
        //    Console.WriteLine(person.ToString());
        //}

        // ------------------------------------------------------------------------------------------------------------------

        //Øvelse 5.8

        //        1.Returner alle two-digit integers sorteret i ascending order.
        //2.Returner alle two-digit integers sorteret i descending order.
        //3.Som i delopgave 1), men I stedet for integers, så skal der returneres strings dvs.
        //f.eks. ”20”, ”31”, ”34”, etc.
        //4.Som i delopgave 2), men skal returnere string af typen “20 even”, “31 uneven”, 
        //etc... 

        int[] numbers = { 34, 8, 56, 31, 79, 150, 88, 7, 200, 47, 88, 20 };

        //IEnumerable<int> sorteretStigende2 = numbers.Where(i => i.ToString().Length == 2).OrderBy(i => i);
        //foreach(int i in sorteretStigende2)
        //{
        //    Console.WriteLine(i);
        //}

        //IEnumerable<int> sorteretFaldende2 = numbers.Where(i => i.ToString().Length == 2).OrderByDescending(i => i);

        //foreach (int i in sorteretFaldende2)
        //{
        //    Console.WriteLine(i);
        //}


        //IEnumerable<string> sorteretStigendeString2 =
        //numbers.Where(i => i.ToString().Length == 2).OrderBy(i => i).Select(i => i.ToString());

        //foreach (string i in sorteretStigendeString2)
        //{
        //    Console.WriteLine(i);
        //}

        //IEnumerable<string> ligeUligeString =
        //    numbers.Where(i => i.ToString().Length == 2).OrderBy(i => i).
        //    Select(i => i % 2 == 0 ? i.ToString() + " even" : i.ToString() + " uneven");

        //foreach (string i in ligeUligeString)
        //{
        //    Console.WriteLine(i);
        //}

        // ------------------------------------------------------------------------------------------------------------------

        //Øvelse 5.9 - Rul til toppen for at se Reset()-metoden.
        //people1.Reset();
        //foreach (Person person in people1) //Print alle
        //{
        //    Console.WriteLine(person.ToString());
        //}

        // ------------------------------------------------------------------------------------------------------------------

        //Øvelse 5.10

        Random random = new Random();

        List<int> randomTal = new List<int>();

        for(int i = 0; i < 100; i++)
        {
            int tal = random.Next(100);
            randomTal.Add(tal);
            
        }

        //foreach(int tal in randomTal)
        //{
        //    Console.WriteLine(tal);
        //}

        //Console.WriteLine(randomTal.Where(i => i % 2 == 1).Count());

        

        //int distinct = randomTal.Distinct().Count();
        //Console.WriteLine(distinct);

        //IEnumerable<int> treFørste = randomTal.Where(i => i % 2 == 1).Take(3); //Kan bruge skip(int x) til at tage objekter senere i listen.
        
        //foreach(int i in treFørste)
        //{
        //    Console.WriteLine(i);
        //}

        int distinctUlige = randomTal.Distinct().Where(i=> i % 2 ==1).Count();
        Console.WriteLine(distinctUlige);




    }


}