namespace Exercise05_05
{
    internal class Program
    {
        public static int GetIndex(int[] nums, int num)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == num) return i;
            }
            throw new NotSupportedException("Значение отсутствует в массиве.");
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6};
            try
            {
                Console.WriteLine("4 = {0}", GetIndex(nums, 5));
                Console.WriteLine("4 = {0}", GetIndex(nums, 7));
            }
            catch(NotSupportedException e)
            {
                Console.WriteLine(e);
                Console.WriteLine("———————————————————————");
                Console.WriteLine(e.Message);
                Console.WriteLine("———————————————————————");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("———————————————————————");
                Console.WriteLine(e.Source);
                Console.WriteLine("———————————————————————");
                Console.WriteLine(e.HelpLink);
            }
        }
    }
}
