namespace Exercise03_05
{
    interface IEx0305
    {
        int Max { get; set; }
        int Min { get; set; }
        string ToString();
    }
    // Вся логика описана в конструкторе
    struct Triple0: IEx0305
    {
        // Проще всего опять описать всё в конструкторе
        // Можно было бы просто использовать Math.max
        // Всегда a > b > c
        private int a, b, c;
        public Triple0(int x)
        {
            if (x > 0)
            {
                a = x;
                b = c = 0;
            }
            else
            {
                a = b = 0;
                c = x;
            }
        }
        public Triple0(int x, int y)
        {
            // x > y
            if (y > x) (x, y) = (y, x);
            if (y > 0)
            {
                a = x;
                b = y;
                c = 0;
            }
            else if (x < 0)
            {
                a = 0;
                b = x;
                c = y;
            }
            else
            {
                a = x;
                b = 0;
                c = y;
            }
        }
        public Triple0(int x, int y, int z)
        {
            // x > y > z
            if (x < y) (x, y) = (y, x);
            if (y < z) (y, z) = (z, y);
            if (x < y) (x, y) = (y, x);
            a = x;
            b = y;
            c = z;
        }
        public int Max
        {
            get => a;
            set => a = value;
        }
        public int Min
        {
            get => c;
            set => c = value;
        }
        public override string ToString()
        {
            return String.Format("a = {0}, b = {1}, c = {2}", a, b, c);
        }
    }
    // С использованием LINQ
    struct Triple1: IEx0305
    {

        private int a, b, c;
        public Triple1(int a)
        {
            this.a = a;
            b = c = 0;
        }
        public Triple1(int a, int b)
        {
            this.a = a;
            this.b = b;
            c = 0;
        }
        public Triple1(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public int Max
        {
            get => new[] { a, b, c }.Max();
            set
            {
                int max = this.Max;
                if (a == max) a = value;
                else if (b == max) b = value;
                else c = value;
            }
        }
        public int Min
        {
            get => new[] { a, b, c }.Min();
            set
            {
                int min = this.Min;
                if (a == min) a = value;
                else if (b == min) b = value;
                else c = value;
            }
        }
        public override string ToString()
        {
            return String.Format("a = {0}, b = {1}, c = {2}", a, b, c);
        }
    }
    // Без использования Max и Min
    struct Triple2 : IEx0305
    {

        private int a, b, c;
        public Triple2(int a)
        {
            this.a = a;
            b = c = 0;
        }
        public Triple2(int a, int b)
        {
            this.a = a;
            this.b = b;
            c = 0;
        }
        public Triple2(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public int Max
        {
            get
            {
                int max = a;
                if (b > a) max = b;
                if (c > max) max = c;
                return max;
            }
            set
            {
                int max = this.Max;
                if (a == max) a = value;
                else if (b == max) b = value;
                else c = value;
            }
        }
        public int Min
        {
            get
            {
                int min = a;
                if (b < a) min = b;
                if (c < min) min = c;
                return min;
            }
            set
            {
                int min = this.Min;
                if (a == min) a = value;
                else if (b == min) b = value;
                else c = value;
            }
        }
        public override string ToString()
        {
            return String.Format("a = {0}, b = {1}, c = {2}", a, b, c);
        }
    }
    internal class Program
    {
        static void Test(IEx0305 a)
        {
            Console.WriteLine("{0}. Min = {1}, Max = {2}",a, a.Min, a.Max);
            a.Min = -100;
            a.Max = 100;
            Console.WriteLine("{0}. Min = {1}, Max = {2}", a, a.Min, a.Max);
            Console.WriteLine(new String('—', 20));
        }
        static void Main(string[] args)
        {
            IEx0305 a;
            a = new Triple0(10); Test(a);
            a = new Triple0(10, 5); Test(a);
            a = new Triple0(1, 2, 3); Test(a);
            a = new Triple0(3, 2, 3); Test(a);
            a = new Triple0(3, 2, 1); Test(a);
            a = new Triple0(2, 3, 1); Test(a);
            a = new Triple0(0); Test(a);
            a = new Triple0(3, 3, 3); Test(a);

            a = new Triple1(10); Test(a);
            a = new Triple1(10, 5); Test(a);
            a = new Triple1(1, 2, 3); Test(a);
            a = new Triple1(3, 2, 3); Test(a);
            a = new Triple1(3, 2, 1); Test(a);
            a = new Triple1(2, 3, 1); Test(a);
            a = new Triple1(0); Test(a);
            a = new Triple1(3, 3, 3); Test(a);

            a = new Triple2(10); Test(a);
            a = new Triple2(10, 5); Test(a);
            a = new Triple2(1, 2, 3); Test(a);
            a = new Triple2(3, 2, 3); Test(a);
            a = new Triple2(3, 2, 1); Test(a);
            a = new Triple2(2, 3, 1); Test(a);
            a = new Triple2(0); Test(a);
            a = new Triple2(3, 3, 3); Test(a);
        }
    }
}
