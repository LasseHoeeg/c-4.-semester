// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

using Øvelse4._1;

class Program           //husk Main skal i en klasse
{

    public static void Main()
    {
        {
            string langtxt = "abc def ghi j";
            string korttxt = "abc";

            bool l = langtxt.Lang();
            Console.WriteLine("Lang: " + l);
            bool k = korttxt.Lang();
            Console.WriteLine("Kort: " + k);

        }
    }


}