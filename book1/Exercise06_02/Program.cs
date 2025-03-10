namespace Exercise06_02
{
    class Symbols
    {
        public char start, end;

        public void get()
        {
            if (end < start)
            {
                char temp = start;
                start = end;
                end = temp;
            }
            Console.Write("|");
            for (char i = start; i <= end; i++)
            {
                Console.Write(" " + i + " |");
            }
        }
    }
    internal class Program
    {
        static int Main(string[] args)
        {
            Symbols a = new Symbols();
            a.start = 'к';
            a.end = 'А';
            a.get();
            return 10;
        }
    }
}
