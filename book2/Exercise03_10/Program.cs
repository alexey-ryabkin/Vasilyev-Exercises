namespace Exercise03_10
{
    struct Single
    {
        internal int a;
        // Попробую без своего конструктора
        public static Pair operator +(Single a, Single b)
        {
            Pair c = new Pair();
            c.a = a.a;
            c.b = b.a;
            return c;
        }
        public override string ToString()
        {
            return "Mu" + a;
        }
    }
    struct Pair
    {
        internal int a, b;
        public static Single[] operator ~(Pair c)
        {
            Single[] ab = new Single[2];
            ab[0].a = c.a;
            ab[1].a = c.b;
            return ab;
        }
        public override string ToString()
        {
            return String.Format("Mu{0},{1}",a,b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Single 
                a = new Single(), 
                b = new Single();
            a.a = 8;
            b.a = 10;
            Pair ab = a + b;
            Console.WriteLine("{0} и {1}", a, b); // Mu8 и Mu10
            Console.WriteLine(ab); // Mu8,10
            Console.WriteLine("{0} и {1}", (~ab)[0], (~ab)[1]); // Mu8 и Mu10
        }
    }
}
