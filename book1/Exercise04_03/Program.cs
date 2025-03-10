namespace Exercise04_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 10;
            char[] chars = new char[length];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)('a' + 2 * i);
            }

            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write("{0,2}", chars[i]);
            }
            Console.WriteLine();
            for (int i = chars.Length - 1; i >=0 ; --i)
            {
                Console.Write("{0,2}", chars[i]);
            }
        }
    }
}
