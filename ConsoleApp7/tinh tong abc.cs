using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int a = 0;
        int b = 0;
        int c = 0;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());  
        c = int.Parse(Console.ReadLine());

        double sum = (a + b + c) / 3.00;
        Console.WriteLine(Math.Round(sum, 2));
    }       
}