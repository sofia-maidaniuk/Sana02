using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input coef int 'a' for quadratic equation: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Input coef int 'b' for quadratic equation: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Input coef int 'c' for quadratic equation: ");
        int c = int.Parse(Console.ReadLine());

        double d;
        double x1, x2, x;

        d = b*b - 4 * a * c;

        if (d < 0)
            Console.WriteLine("\nEquation hasn`t real number root!\n");
        else if (d == 0)
        {
            x = -b / (2 * a);
            Console.WriteLine($"\nEquation has only 1 root: {x}\n");
        }
        else
        {
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine($"\nEquation has 2 roots: x1 = {x1}, x2 = {x2}"); 
        }
    }
}


