namespace Exercise04_07
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            int[] nums = new int[2];
            fixed(int* pint = nums)
            {
                byte* p = (byte*)pint;
                for (byte i = 1; i <= 8; i++)
                {
                    p[i - 1] = i;
                }
                for (int i = 0; i < 8; i++)
                {
                    Console.WriteLine(p[i]);
                }
                Console.WriteLine("{0}, {1}", 1 + 256 * 2 + 256 * 256 * 3 + 256*256*256*4, 5 + 256 * 6 + 256 * 256 * 7 + 256 * 256 * 256 * 8);
                Console.WriteLine("{0}, {1}", nums[0], nums[1]);
            }
        }
    }
}
