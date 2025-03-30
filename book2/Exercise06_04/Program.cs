namespace Exercise06_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[20];
            int currentTwos = 0, 
                currentThrees = nums.Length - 1;
            Thread twos = new Thread(() => 
            {
                nums[0] = 1;
                int index = 1;
                while (index < currentThrees)
                {
                    lock (nums)
                    {
                        currentTwos = index;
                        nums[index] = nums[index - 1] * 2;
                    }
                    index++;
                    Thread.Sleep(50);
                }
            });
            Thread threes = new Thread(() => 
            {
                nums[nums.Length - 1] = 1;
                int index = nums.Length - 2;
                while (index > currentTwos)
                {
                    lock (nums)
                    {
                        currentThrees = index;
                        nums[index] = nums[index + 1] * 3;
                    }
                    index--;
                    Thread.Sleep(100);
                }
            });
            twos.Start();
            threes.Start();
            while (twos.IsAlive || threes.IsAlive)
            {
                Console.Write("{0, 4}", nums[0]);
                for (int i = 1; i < nums.Length; i++) Console.Write(" {0, 4}", nums[i]);
                Console.Write("\n");
                Thread.Sleep(25);
            }
        }
    }
}
