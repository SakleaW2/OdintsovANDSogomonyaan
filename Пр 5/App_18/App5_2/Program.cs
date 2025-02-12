namespace App5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //многомерные массивы -> 5 формула
            int n = 5; 
            int[,] matrix = FormMatrix(n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int[,] FormMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            for (int j = 0; j < n; j++)
            {
                matrix[0, j] = 1;
            }
            for (int j = 0; j < n; j++)
            {
                matrix[n - 1, j] = 1;
            }
            for (int i = 1; i < n - 1; i++)
            {
                matrix[i, 0] = 1;
                matrix[i, n - 1] = 1;
            }
            return matrix;
        }
    }
}
