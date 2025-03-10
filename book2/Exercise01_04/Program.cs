namespace Exercise01_04
{
    abstract class Pair
    {
        protected int first;
        protected int second;

        public Pair(int first, int second)
        {
            this.first = first;
            this.second = second;
        }
        public abstract int this[int index] { get; set; }
    }
    interface Calculations
    {
        int Calculate(int arg);
    }
    class Couple:Pair, Calculations
    {
        public Couple(int first, int second): base(first, second) { }
        public override int this[int index]
        {
            get
            {
                if (index % 2 == 0) { return first; }
                else { return second; }
            }
            set
            {
                if (index % 2 == 0) { first = value; }
                else { second = value; }
            }
        }
        public int Calculate(int arg)
        {
            return (first + second) * arg;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test(5, 10, 2);
            Test(-10, -2, 4);
        }
        static void Test(int first, int second, int arg)
        {
            Couple a = new Couple(first, second);
            Calculations b = a;
            Console.WriteLine("({0} + {1}) * {2} = {3}", first, second, arg, a.Calculate(arg));
            Console.WriteLine("({0} + {1}) * {2} = {3}", first, second, arg, b.Calculate(arg));
            a[10] = 15;
            a[11] = 20;
            Console.WriteLine("15 = {0}; 20 = {1}", a[8], a[-9]);
            Console.WriteLine("({0} + {1}) * {2} = {3}", a[10], a[11], 5, a.Calculate(5));
            Console.WriteLine("({0} + {1}) * {2} = {3}", a[10], a[11], 5, b.Calculate(5));
            Console.WriteLine();
        }
    }
}
