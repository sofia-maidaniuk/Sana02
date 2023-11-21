using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Write 5 student marks: \n");
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        float d = float.Parse(Console.ReadLine());
        float e = float.Parse(Console.ReadLine());

        float average = 0.0f;

        average = (a + b + c + d + e) / 5;
        
        if (average < 50)
            Console.WriteLine($"\n{average} average mark isn't enough");
        else
            Console.WriteLine($"\n{average} average mark is enough. Good luck on exams.");
    }
}


