
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace App5
{
    internal class Program
    {
        static void Main()
        {
            const int n = 5;
            int[,] Mat = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Mat[i, j] = rnd.Next(10);
                    Console.Write($"  {Mat[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            int sum = 0;
            int p = 1;
           for (int i = 0;i < n; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    
                    if (i >= j && i + j <= n - 1)
                    {
                        p *= Mat[i, j];
                        sum += Mat[i, j];
                    }
                    else
                    {
                        Mat[i, j] = 0;
                    }
                    Console.Write($"  {Mat[i, j]}");
                }
                Console.WriteLine();
            }
           Console.WriteLine(sum);
            Console.WriteLine(p);
        }
    }
}

