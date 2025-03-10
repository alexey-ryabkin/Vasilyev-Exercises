namespace Exercise03_04
{
    struct Nums
    {
        private int[] nums;
        private int min, max;
        double mean;
        public Nums(int size)
        {
            Random rng = new Random();
            nums = new int[size];
            int sum = min = max = nums[0] = rng.Next(101);
            for (int i = 1; i < size; i++)
            {
                nums[i] = rng.Next(11);
                if (min > nums[i]) min = nums[i];
                if (max < nums[i]) max = nums[i];
                sum += nums[i];
            }
            mean = (double)sum / size;
        }
        public override string ToString()
        {
            string output = string.Empty;
            output += "Объект Nums\n";
            output += nums[0].ToString();
            for (int i = 1; i < nums.Length; i++)
            {
                output += ", " + nums[i];
            }
            output += ".\n";
            output += string.Format("Максимум — {0}, минимум — {1}, среднее — {2}", Max, Min, Mean);
            return output;
        }
        public string altToString()
        {
            return string.Join(", ", nums); ;
        }
        // В задаче написано, что должны быть методы, но я посчитал всё в конструкторе и сделал свойства
        public int Max => max;
        public int Min => min;
        public double Mean => mean;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Nums[] a = new Nums[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = new Nums(4);
                Console.WriteLine(a[i]);
                //Console.WriteLine(a[i].altToString());
            }
        }
    }
}
