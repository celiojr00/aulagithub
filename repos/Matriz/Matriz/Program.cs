using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine(" Position " + i + "," + j + ":");
                        if (j > 0) { Console.WriteLine(" Left: " + mat[i, j - 1]); }
                        if (i > 0) { Console.WriteLine(" Up: " + mat[i - 1, j]); }
                        if (j < m - 1) { Console.WriteLine(" rigth: " + mat[i, j + 1]); }
                        if (i < n - 1) { Console.WriteLine(" Down: " + mat[i + 1, j]); }
                    }
                }
            }
        }
    }
}
            /*Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);*/