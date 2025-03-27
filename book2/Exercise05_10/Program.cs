namespace Exercise05_10
{
    class Bytes
    {
        byte[] nums;
        public Bytes()
        {
            nums = new byte[10];
        }
        public int this[int i]
        {
            get
            {
                return nums[i];
            }
            set
            {
                try { nums[i] = checked((byte)value); }
                catch(OverflowException) { nums[i] = 255; }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bytes a = new Bytes();
            a[0] = 300;
            Console.WriteLine(a[0]);
            a[0] = -300;
            Console.WriteLine(a[0]);
        }
    }
}
