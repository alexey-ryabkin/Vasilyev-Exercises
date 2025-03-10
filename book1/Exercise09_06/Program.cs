using System.Security.AccessControl;

namespace Exercise09_06
{
    class Moved_nums
    {
        int[] nums;
        int left;

        public Moved_nums(int left, int rigth)
        {
            if (left > rigth) (left, rigth) = (rigth, left);
            nums = new int[rigth - left + 1];
            Random random = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(100) ;
            }
            this.left = left;
        }

        public int this[int index]
        {
            get
            {
                return nums[index - left];
            }
            set
            {
                nums[index - left] = value;
            }
        }

        public override string ToString()
        {
            string a = "Левая граница: " + left + 
                "Правая граница: " + (left + nums.Length - 1) + "\n";
            for (int i = 0; i < nums.Length; i++)
            {
                a += nums[i].ToString() + " ";
            }
            return a;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Moved_nums a = new Moved_nums(10, 20);
            Console.WriteLine(a);
            a[20] = 69;
            for (int i = 11; i < 16; i++)
            {
                a[i] = 0;
            }
            Console.WriteLine(a);
        }
    }
}
