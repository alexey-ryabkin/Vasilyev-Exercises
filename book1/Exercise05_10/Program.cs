namespace Exercise05_10
{
    internal class Program
    {
        static string combine(string a, params char[] b)
        {
            foreach (char c in b)
            {
                a += c;
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(combine("string", 'a', 'b', 'c', 'd'));
        }
    }
}
