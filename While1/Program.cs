using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number to use:");
        int n = int.Parse(Console.ReadLine());

        double a = 0;
        for (int i = 1; i <= n; i++)
            a += Math.Pow(-1, i) / (2 * i + 1);

        Console.WriteLine($"Result = {a}");
    }
}


