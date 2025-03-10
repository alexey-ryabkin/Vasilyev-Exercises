using System.Numerics;

namespace Exercise05_09
{
    internal class Program
    {
        static int[] minMax(params int[] nums)
        {
            int min, max;
            min = max = nums[0];
            foreach (int a in nums)
            {
                if (a < min) min = a;
                if (a > max) max = a;
            }
            return [min, max];
        }
        static void Main(string[] args)
        {
            foreach (int a in minMax(0, -10, 50, 5, 7, 9, -9999999))
            {
                Console.WriteLine(a);
            }
        }
    }
}
