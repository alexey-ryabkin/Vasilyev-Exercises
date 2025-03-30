using System.Data.Common;

namespace Exercise06_08
{
    internal class Program
    {
        static bool IsAnyAlive(Thread[] threads)
        {
            for (int i = 0; i < threads.Length; i++)
            {
                if (threads[i].IsAlive)
                {
                    return true;
                }
            }
            return false;
        }
        static void ShowMatrix(int[,] matrix)
        {
            Console.WriteLine("Matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j], 4}");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int rows    = random.Next(4, 20),
                columns = random.Next(4, 20);
            int[,] matrix = new int[rows, columns];
            Thread[] threads = new Thread[columns];
            for (int j = 0; j < columns; j++)
            {
                int r = j;
                threads[r] = new Thread(() =>
                {
                    for (int i = 0; i < rows; i++)
                    {
                        matrix[i, r] = random.Next(1000);
                        int temp = random.Next(100, 1500);
                        Thread.Sleep(temp);
                    }
                });
                threads[r].Start();
            }
            while (IsAnyAlive(threads))
            {
                Console.Clear();
                ShowMatrix(matrix);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Результат");
            ShowMatrix(matrix);
        }
    }
}
