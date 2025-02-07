namespace App3
{
    internal class Program
    {
        static void Main()
        {
            const int n = 8;
            int[,] Mat = new int[n,n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 0 && j%2 ==0 || (i+j) % 2==0) 
                    {
                        Mat[i, j] = 1;
                    }
                    else {
                        Mat[i, j] = 0;
                    }
                    Console.Write($"  {Mat[i,j]}");
                } Console.WriteLine();
            }

        }
    }
}
