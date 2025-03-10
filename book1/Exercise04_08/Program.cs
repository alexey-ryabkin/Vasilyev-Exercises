using System.Runtime.ExceptionServices;

namespace Exercise04_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 7, cols = 3;
            int[,] nums = new int[rows, cols];
            int[,] numsTransposed = new int[cols, rows];
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    nums[i, j] = rnd.Next(100);
                }
            }

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(nums[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    numsTransposed[j, i] = nums[i, j];
                }
            }
            nums = numsTransposed;

            Console.WriteLine("Транспонированный массив:");
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write(nums[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
