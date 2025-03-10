namespace Exercise05_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] nums = {{0, 1, 2, 3}, {4, 5, 6, 60}, {7, 8, 9, 10}, {10, 11, 12, 13}};
            int[,] nums = new int[0, 0];
            int x, y, max;

            max = getMax(nums, out x, out y);

            Console.WriteLine("Макс: {0}, X:{1}, Y: {2}.",max, x, y);
        }

        static int getMax(int[,] nums, out int xMax, out int yMax)
        {
            xMax = 0;
            yMax = 0;
            if (nums.Length == 0) return 0;
            int max = nums[0, 0];
            for (int x = 0; x < nums.GetLength(0); x++) 
            {
                for (int y = 1; y < nums.GetLength(1); y++)
                {
                    int a = nums[x, y];
                    if (a > max)
                    {
                        max = a;
                        xMax = x;
                        yMax = y;
                    }
                }
            }
            return max;
        }
    }
}
