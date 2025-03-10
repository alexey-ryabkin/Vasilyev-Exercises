namespace Exercise08_10
{
    class Letter
    {
        char a;

        public Letter()
        {
            Random rng = new Random();
            a = (char)rng.Next('A','A' + 10);
        }

        public Letter(string a)
        {
            this.a = (char)0;
            foreach (char c in a) this.a += c;
        }

        public static string operator + (Letter a, Letter b)
        {
            return a.a.ToString() + b.a.ToString();
        }

        public static implicit operator Letter (string letters)
        {
            return new Letter(letters);
        }

        public static Letter operator - (Letter a, Letter b)
        {
            return new Letter(((char)(a.a - b.a)).ToString());
        }

        public override string ToString()
        {
            return a.ToString() + (int)a;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Letter[] a = new Letter[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new Letter();
                Console.WriteLine(a[i]);
            }

            for (int i = 0; i < a.Length - 1; i++)
            {

                Console.WriteLine("{0} + {1} = {2}", a[i + 1], a[i], a[i + 1] + a[i]);
                Console.Write("{0} += {1} = ", a[i + 1], a[i]);
                a[i + 1] += a[i];
                Console.WriteLine(a[i + 1]);
                Console.WriteLine("{0} -= {1} = {2}", a[i + 1], a[i], a[i + 1] -= a[i]);
                Console.WriteLine();

            }
        }
    }
}
