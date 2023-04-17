namespace WebApplication1.Models
{
    public class Person
    {
        public string Fornavn { get; set; }

        public string Efternavn { get; set; }
        
        public int Alder { get; set; }

        public Person(string fornavn, string efternavn, int alder)
        {
            Fornavn = fornavn;
            Efternavn = efternavn;
            Alder = alder;
        }

        public Person()
        {

        }
    }
}
