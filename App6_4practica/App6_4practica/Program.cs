using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите [a,b] число:");
        string inputA = Console.ReadLine();
        string inputB = Console.ReadLine();

        Console.WriteLine("Введите h- шаг :");
        string inputh = Console.ReadLine();
        int a, b, h;
        try
        {
            a = Convert.ToInt32(inputA);
            b = Convert.ToInt32(inputB);
            h = Convert.ToInt32(inputh);
            for (int i = a; i <= b; i += h)
            {
                double F = 2 / Math.Pow(Math.Sin(i + 1), 2);
                Console.WriteLine($"{i} | {F}");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Ошибка ввода: {ex.Message}");
        }
    }
}

