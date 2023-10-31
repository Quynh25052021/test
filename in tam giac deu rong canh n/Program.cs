using System;
internal class Program
{
    private static void Main(string[] args)
    {
        //Console.Write("Nhập n: ");
        int n = 0;
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int space = n - i;

            for (int j = 1; j <= space; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        for (int i = n - 1; i >= 1; i--)
        {
            int space = n - i;

            for (int j = 1; j <= space; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

    }

}