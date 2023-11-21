using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number to use:");
        int n = int.Parse(Console.ReadLine());

        long c = 0;
        long factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            c += factorial;
        }

        Console.WriteLine($"Result of sum all factorials is {c}");
        
    }
}
