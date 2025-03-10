namespace Exercise01_06
{
    interface IEncoder
    {
        int this[char letter] { get; }
    }
    interface IDecoder
    {
        char this[int code] { get; }
    }
    class Actor: IEncoder, IDecoder
    {
        public int this[char letter]
        {
            get 
            {
                return letter + 1;
            }
        }
        public char this[int code]
        {
            get
            {
                return (char)(code - 1);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Test('D', 65);
            Test('d', 106);
        }
        static void Test(char letter, int number)
        {
            Actor a = new Actor();
            IEncoder e = a;
            IDecoder d = a;
            Console.WriteLine("{0} = {1} = {2}", a[letter], e[letter], d[letter]);
            Console.WriteLine("{0} = {1} = {2}", a[number], e[(char)number], d[number]);
            Console.WriteLine();
        }
    }
}
