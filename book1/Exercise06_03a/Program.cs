namespace Exercise06_03a
{
    class TwoInts
    {
        int a, b;
        // Один конструктор, описывающий все три варианта
        public TwoInts(int a = 1, int b = 2)
        {
            this.a = a;
            this.b = b;
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
