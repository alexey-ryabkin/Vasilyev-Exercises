namespace Exercise07_10
{
    class MyClass
    {
        int[] nums;
        int len;
        double mean;

        public MyClass(uint len = 0)
        {
            Random rng = new Random();
            int sum = 0;
            this.len = (int)len;
            this.nums = new int[len];
            for (int i = 0; i < len; i++)
            {
                this.nums[i] = rng.Next(0, 100);
                sum += this.nums[i];
            }
            this.mean = (double)sum / this.nums.Length;
        }

        public override string ToString()
        {
            string output = string.Empty;
            output += "Число элементов: " + this.len.ToString() + "\n"
                + "Среднее значение: " + this.mean + "\n"
                + "Содержимое объекта: ";
            for (int i = 0; i < this.nums.Length - 1; i++)
            {
                output += this.nums[i].ToString() + ", ";
            }
            if (nums.Length != 0) output += this.nums[nums.Length - 1].ToString() + ".";
            return output;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass(40);
            Console.WriteLine(a);
            a = new MyClass();
            Console.WriteLine(a);
            a = new MyClass(1);
            Console.WriteLine(a);
            //a = new MyClass(-1);
            //Console.WriteLine(a);
        }
    }
}
