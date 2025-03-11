namespace Exercise03_09
{
    struct NumIndex
    {
        private int num, index;
        public NumIndex(int num, int index)
        {
            this.num = num;
            this.index = index;
        }
        public static NumIndex Mindex(int[] nums)
        {
            NumIndex output = new NumIndex(0, -1); // По умолчанию
            if (nums.Length > 0) output = new NumIndex(nums[0], 0);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < output.num)
                {
                    output = new NumIndex(nums[i], i);
                }
            }
            return output;
        }
        public static NumIndex Maxdex(int[] nums)
        {
            NumIndex output = new NumIndex(0, -1); // По умолчанию
            if (nums.Length > 0) output = new NumIndex(nums[0], 0);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > output.num)
                {
                    output = new NumIndex(nums[i], i);
                }
            }
            return output;
        }
        public override string ToString()
        {
            return string.Format("Символ {0} на позиции {1}", num, index);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumIndex.Mindex([5,0,1,2,3,4])); // 0 на 1
            Console.WriteLine(NumIndex.Maxdex([5,0,1,2,3,4])); // 5 на 0
        }
    }
}
