namespace Exercise03_06
{
    struct Pair
    {
        public int a, b;
        public Pair(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static Pair operator +(Pair c, Pair d) => new Pair(c.a + d.a, c.b + d.b);
        public static Pair operator -(Pair c, Pair d) => new Pair(c.a - d.a, c.b - d.b);
        public static Pair operator *(Pair c, Pair d) => new Pair(c.a * d.a, c.b * d.b);
        // Минимум
        public static int operator !(Pair c) => (c.a < c.b) ? c.a : c.b;
        // Максимум
        public static int operator ~(Pair c) => (c.a > c.b) ? c.a : c.b;
        public override string ToString()
        {
            return string.Format("({0}, {1})", a, b);
        }
    }
    internal class Program
    {
        static void Test(Pair c, Pair d)
        {
            Console.WriteLine("{0} + {1} = {2}", c, d, c + d); 
            Console.WriteLine("{0} - {1} = {2}", c, d, c - d); 
            Console.WriteLine("{0} * {1} = {2}", c, d, c * d); 
            Console.WriteLine("Min{0} = {1}", c, !c);
            Console.WriteLine("Min{0} = {1}", d, !d);
            Console.WriteLine("Max{0} = {1}", c, ~c);
            Console.WriteLine("Max{0} = {1}", d, ~d);
            Console.WriteLine(new string('-', 30));
        }
        static void Main(string[] args)
        {
            Pair c, d;
            c = new Pair(1, 2);
            d = new Pair(3, 4);
            Test(c, d);
            c = new Pair(0, 0);
            d = new Pair(10, 45);
            Test(c, d);
        }
    }
}
