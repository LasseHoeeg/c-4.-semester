// See https://aka.ms/new-console-template for more information





using Lektion02;

string input = Console.ReadLine();

int n = int.Parse(input);

while (n != 0)
{
    Fibonacci.fibo(n);
    input = Console.ReadLine();
    n = int.Parse(input);
}

//while (n != 0)
//{
//    Console.WriteLine(Fibonacci.fiboArray(n));
//    input = Console.ReadLine();
//    n = int.Parse(input);
//}
