namespace Exercise08_07
{
    class Text
    {
        string a;

        public Text()
        {
            Random rng = new Random();
            char[] b = new char[rng.Next(30)];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = (char)rng.Next('a', 'a' + 53);
            }
            a = new string(b);
        }

        public Text(int len)
        {
            a = new string('A', len);
        }

        public static explicit operator string (Text obj)
        {
            return obj.a + "expl";
        }

        public static explicit operator int (Text obj)
        {
            return obj.a.Length;
        }

        public static explicit operator char (Text obj)
        {
            return obj.a[0];
        }

        public static explicit operator Text (int n)
        {
            return new Text(n);
        }

        public override string ToString()
        {
            return a;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Text[] a = new Text[20];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new Text();
                Console.WriteLine((string)a[i]);
                Console.WriteLine((int)a[i]);
                Console.WriteLine((char)a[i]);
                Console.WriteLine((Text)(int)a[i]);
                Console.WriteLine();
            }
        }
    }
}
