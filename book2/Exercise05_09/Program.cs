namespace Exercise05_09
{
    class IndexTooHigh: Exception
    {
        public IndexTooHigh(string message) : base(message) { }
    }
    class IndexTooLow: ApplicationException
    {
        public IndexTooLow(string message) : base(message) { }
    }
    class MyNums
    {
        private int[] nums;
        public MyNums() { nums = new int[10]; }
        public int this[int index]
        {
            get
            {
                if (index < 0) throw new IndexTooLow("");
                if (index >= nums.Length) throw new IndexTooHigh("");
                return nums[index];
            }
            set
            {
                if (index < 0) throw new IndexTooLow("");
                if (index >= nums.Length) throw new IndexTooHigh("");
                nums[index] = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyNums a = new MyNums();
            try { a[-1] = 0; }
            catch(IndexTooLow e) { Console.WriteLine(e.GetType()); }
            try { int b = a[-1]; }
            catch(IndexTooLow e) { Console.WriteLine(e.GetType()); }
            try { a[11] = 0; }
            catch(IndexTooHigh e) { Console.WriteLine(e.GetType()); }
            try { int b = a[11]; }
            catch (IndexTooHigh e) { Console.WriteLine(e.GetType()); }
        }
    }
}
