namespace Exercise09_01
{
    class MyChar
    {
        public char a;

        public char character
        {
            get
            {
                return (char)(a + 1);
            }
            set
            {
                a = (char)(value + 1);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyChar b = new MyChar();
            Console.WriteLine(b.character);
            Console.WriteLine((int)b.a);
            b.character = 'a';
            Console.WriteLine(b.character);
            Console.WriteLine(b.a);
        }
    }
}
