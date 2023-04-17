

using Øvelse3._2;


//var medarbejderCollection = new MedarbejderList<CprNr>();
CprNr c1 = new CprNr("12/01/1960", "2222");
CprNr c2 = new CprNr("20/03/1965", "3333");
CprNr c3 = new CprNr("16/05/1970", "4444");
Adresse a1 = new Adresse("Bullervej", 64);

Mekaniker m1 = new Mekaniker(1, c1, "Bob", a1, 2000, 100);
Synsmand s1 = new Synsmand(2, c2, "Bo", a1, 2001, 300, 20);
Værkfører v1 = new Værkfører(3, c3, "John", a1, 2005, 200, 2010, 150);



//medarbejderCollection.AddElement(m1.cprNr, m1);
//medarbejderCollection.AddElement(s1.cprNr, s1);
//medarbejderCollection.AddElement(s1.cprNr, s1);
//medarbejderCollection.AddElement(v1.cprNr, v1);

//Console.WriteLine(medarbejderCollection.Size());
//Console.WriteLine(medarbejderCollection.GetElement(v1.cprNr));
//var medarbejderCollection2 = new MedarbejderList<int>(); //Opgaven lyder på string, men det er fordi den antager mNummer er en string
//medarbejderCollection2.AddElement(m1.medarbejderNummer, m1);
//medarbejderCollection2.AddElement(s1.medarbejderNummer, s1);
//medarbejderCollection2.AddElement(s1.medarbejderNummer, s1);
//medarbejderCollection2.AddElement(v1.medarbejderNummer, v1);

//Console.WriteLine(medarbejderCollection2.Size());
//Console.WriteLine(medarbejderCollection2.GetElement(v1.medarbejderNummer));

Firma f1 = new Firma(a1);

var medarbejderCollection3 = new MedarbejderList<Adresse,object>(); //Opgaven lyder på string, men det er fordi den antager mNummer er en string

medarbejderCollection3.AddElement(f1.Adresse(), f1); //Alle pladser er optaget, fordi de har den samme adresse
medarbejderCollection3.AddElement(m1.Adresse(), m1);
medarbejderCollection3.AddElement(s1.Adresse(), s1);
//medarbejderCollection3.AddElement(s1.Adresse(), s1);
medarbejderCollection3.AddElement(v1.Adresse(), v1);

Console.WriteLine(medarbejderCollection3.Size());
Console.WriteLine(medarbejderCollection3.GetElement(m1.Adresse()).ToString());

//foreach(var item in medarbejderCollection3) //Fungerer umiddelbart ikke på dictionary
//{
//    Console.WriteLine(item);
//}

//List<Medarbejder> list = new List<Medarbejder>();
//list.Add(m1);   
//list.Add(s1);
//list.Add(v1);

//foreach(Medarbejder m in list)
//{
//    Console.WriteLine(m.ToString());
//    Console.WriteLine(m.BeregnUgeLøn());
//}
