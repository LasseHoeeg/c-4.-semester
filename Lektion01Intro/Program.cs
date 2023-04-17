// See https://aka.ms/new-console-template for more information

using System;
using Lektion01Intro;
using MyLibrary;


//Console.WriteLine("Hello World!");
//Person person1 = new Person("Martin");
//Console.WriteLine(person1);
//person1.Navn = "Benny";
//Console.WriteLine(person1);
//var Fido = new Animal("hund");
//Console.WriteLine("Er Fido en hund? " + Fido.isDog());
//Console.WriteLine("Hvilket dyr skal oprettes? ");
//int i = 0;
//while (i < 3)
//{
//    Animal.createAnimal();
//    i++;
//}

var list = new MyList();
list.Add(1);
list.Add(2);
list.Add(3);

list.printNumbers();

MyList.createRandomListe();
