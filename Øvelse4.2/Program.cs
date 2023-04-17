// See https://aka.ms/new-console-template for more information


using Øvelse4._2;

class Program { 
static void warningToConsole()
{
    Console.WriteLine("Advarsel til konsol");
}
    static void warningToMail()
    {
        Console.WriteLine("Advarsel til mail");
    }
    static void Main(string[] args)
    {
       
        Powerplant pp = new Powerplant();
        pp.SetWarning(warningToConsole);
        pp.addWarning(warningToMail);
        for (int i = 0; i < 10; i++)
        {
           // pp.CoolDown();
            pp.heatUp();
        }


    }


}