using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number to use:");
        int n = int.Parse(Console.ReadLine());

        double b = 0;
        for (int i = 1; i <= n; i++)
            b += 1 + 1.0 / (i * i);

        Console.WriteLine($"Result = {b}");
    }
}


