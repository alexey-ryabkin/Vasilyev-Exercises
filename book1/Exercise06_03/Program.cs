namespace Exercise06_03
{
    class TwoInts
    {
        int a, b;
        // Разные конструкторы
        public TwoInts()
        {
            a = 1;
            b = 2;
        }
        public TwoInts(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public TwoInts(int a) : this()
        {
            this.a = a;
        }

        public void show()
        {
            Console.WriteLine(a + " " + b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TwoInts
                a = new TwoInts(),
                b = new TwoInts(10),
                c = new TwoInts(20, 30),
                d = new TwoInts();
            a.show();
            b.show();
            c.show();
            d.show();
        }
    }
}
