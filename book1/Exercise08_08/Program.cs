namespace Exercise08_08
{
    class numbers
    {
        int[] a;

        public numbers()
        {
            a = new int[6];
            Random rng = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rng.Next(8);
            }
        }

        public static implicit operator string (numbers n)
        {
            string d = "";
            foreach (int i in n.a)
            {
                d += i + " ";
            }
            return d;
        }

        public static implicit operator int (numbers n)
        {
            int sum = new int();
            foreach (int i in n.a)
            {
                sum += i;
            }
            return sum;
        }

        public static implicit operator numbers (int n)
        {
            numbers a = new numbers();
            a.a = new int[n];
            return a;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            numbers[] a = new numbers[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = new numbers();
                Console.WriteLine((string)a[i]);
                Console.WriteLine((int)a[i]);
                Console.WriteLine((string)(numbers)i);
                Console.WriteLine();
            }

        }
    }
}
