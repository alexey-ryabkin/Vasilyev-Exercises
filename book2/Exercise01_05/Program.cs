namespace Exercise01_05
{
    interface IEncoder
    {
        int Encode(char letter);
    }
    interface IDecoder
    {
        char Decode(int number);
    }
    class Calculator: IEncoder, IDecoder
    {
        public int Encode(char letter)
        {
            return (int)letter;
        }
        public char Decode(int number)
        {
            return (char)number;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test('A');
            Test('a');
            Test('B');
            Test('b');
        }
        static void Test(char letter)
        {
            Console.WriteLine("Тестирую для буквы {0}", letter);
            Calculator a = new();
            IEncoder e = a;
            IDecoder d = a;
            Console.WriteLine("{0} = {1} = {2}", (int)letter, a.Encode(letter), e.Encode(letter));
            Console.WriteLine("{0} = {1} = {2}", letter, a.Decode((int)letter), d.Decode((int)letter));

            Console.WriteLine();
        }
    }
}
