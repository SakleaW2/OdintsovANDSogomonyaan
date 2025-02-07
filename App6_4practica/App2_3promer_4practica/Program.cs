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
            Console.WriteLine("x | F");
            double F = 0;
            for (int i = a, n = 0; i <= b; i += h, n++)
            {
                F += 2*(Math.Pow(i-1,n+1)/((2*n+1)*Math.Pow(i+1,2*n+1)));
                double ln = Math.Log10(F);
                Console.WriteLine($"{i} | {ln}");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Ошибка ввода: {ex.Message}");
        }
    }
}
