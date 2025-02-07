
using System.Reflection.Metadata;

namespace App4
    {
        internal class Program
        {
            static void Main()
            {
                const int n = 8;
                int[,] Mat = new int[n, n];
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Mat[i,j] = rnd.Next(10);
                        Console.Write($"  {Mat[i, j]}");
                    }
                    Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0;i < n; i++)
                {
                
                for (int j = 0; j < n; j++)
                {
                    sum += Mat[i, j];
                   
                    
                }
                Console.WriteLine($"Сумма {i} = {sum}");
                 sum = 0;
            }
            }
            }
        }
    
