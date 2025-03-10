namespace Exercise08_09
{
    class MyNumber
    {
        int a;

        public MyNumber()
        {
            Random rng = new Random();
            a = rng.Next(11);
        }

        public MyNumber(int a)
        {
            this.a = a;
        }

        public static MyNumber operator + (MyNumber a, MyNumber b)
        {
            return new MyNumber(a.a + b.a);
        }

        public static MyNumber operator - (MyNumber a, MyNumber b)
        {
            return new MyNumber(a.a - b.a);
        }

        public static MyNumber operator * (MyNumber a, MyNumber b)
        {
            return new MyNumber(a.a * b.a);
        }

        public override string ToString()
        {
            return a.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyNumber[] a = new MyNumber[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new MyNumber();
                Console.WriteLine(a[i]);
            }

            for (int i = 0; i < a.Length - 1; i++)
            {
                Console.Write("{0} + {1} = ", a[i], a[i + 1]);
                a[i] += a[i + 1];
                Console.WriteLine(a[i]);
                Console.Write("{0} - {1} = ", a[i], a[i + 1]);
                a[i] -= a[i + 1];
                Console.WriteLine(a[i]);
                Console.Write("{0} * {1} = ", a[i], a[i + 1]);
                a[i] *= a[i + 1];
                Console.WriteLine(a[i]);
                Console.WriteLine();
            }
        }
    }
}
