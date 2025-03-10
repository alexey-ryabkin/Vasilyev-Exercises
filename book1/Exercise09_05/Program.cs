namespace Exercise09_05
{
    class Igor
    {
        private static int odd_number = 1;
        public static int odds
        {
            get
            {
                int odd = 2 * odd_number - 1;
                odd_number++;
                return odd;
            }
            set
            {
                odd_number = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Igor.odds);
            Console.WriteLine(Igor.odds);
            Console.WriteLine(Igor.odds);
            Console.WriteLine(Igor.odds);
            Igor.odds = 0;
            Console.WriteLine(Igor.odds);
            Igor.odds = 5;
            Console.WriteLine(Igor.odds);
            Igor.odds = -5;
            Console.WriteLine(Igor.odds);
            Igor.odds = 15;
            Console.WriteLine(Igor.odds);
        }
    }
}
