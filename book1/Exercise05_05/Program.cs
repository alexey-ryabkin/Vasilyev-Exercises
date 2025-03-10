namespace Exercise05_05
{
    internal class Program
    {
        static double mean(int[] nums)
        {
            int sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return (double) sum / nums.Length;
        }
        static void Main(string[] args)
        {
            int[] nums = { 0, 0, 0, 1, 1, 10, 30 };
            Console.WriteLine(mean(nums));
        }
    }
}
