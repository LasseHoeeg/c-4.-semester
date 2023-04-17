namespace Øvelse2PartialView.Models
{
    public class Person
    {
        public string Navn { get; set; }

        public Person(string navn)
        {
            Navn = navn;
        }
        public Person() { }

    }
}
