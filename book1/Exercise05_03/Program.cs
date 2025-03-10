using System.Reflection.Metadata.Ecma335;

namespace Exercise05_03
{
    internal class Program
    {
        static int[] nFirstItems(int[] nums, int n)
        {
            int[] newNums;
            if (nums.Length > n)
            {
                newNums = new int[n];
            }
            else
            {
                newNums = new int[nums.Length];
            }
            for (int i = 0; i < nums.Length && i < n; i++) 
            {
                newNums[i] = nums[i];
            }
            return newNums;
        }

        static void Main(string[] args)
        {
            int[] nums = {0, 1, 2, 3, 4, 5, 6};
            int n = 60;
            int[] newNums = nFirstItems(nums, n);
            nums[0] = 10;
            foreach (int i in newNums)
            {
                Console.WriteLine(i);
            }
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}
