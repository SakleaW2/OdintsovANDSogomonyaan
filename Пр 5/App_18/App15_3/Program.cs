namespace App15_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("15 Вычислить сумму и число положительных элементов матрицы размерностью NxN, находящихся над" +
                "\r\nглавной диагональю.");
            int N = 9; 
            int[,] matrix = GenerateMatrix(N);
            PrintMatrix(matrix, N);

            int sum = 0;
            int countPositive = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sum += matrix[i, j];
                        countPositive++;
                    }
                }
            }
            Console.WriteLine($"\nСумма положительных элементов над главной диагональю: {sum}");
            Console.WriteLine($"Количество положительных элементов над главной диагональю: {countPositive}");
        }
        static int[,] GenerateMatrix(int N)
        {
            var rand = new Random();
            int[,] matrix = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rand.Next(-9, 10); 
                }
            }

            return matrix;
        }
        static void PrintMatrix(int[,] matrix, int N)
        {
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }
        }
    }
}