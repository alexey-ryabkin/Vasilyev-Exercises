namespace Exercise03_08
{
    struct CharWrap
    {
        private char letter;
        public CharWrap(char letter)
        {
            this.letter = letter;
        }
        public override string ToString()
        {
            return "Mu" + letter.ToString(); //MuCOSA
        }
    }
    struct StringWrap
    {
        private string text;
        public StringWrap(string text)
        {
            this.text = text;
        }
        public override string ToString()
        {
            return "Mu" + text;
        }
        // Требуется метод, но больше подходит индексатор
        public CharWrap this[int index]
        {
            get
            {
                return new CharWrap(text[index]);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StringWrap a = new StringWrap("Hello, World!");
            Console.WriteLine(a[2]); //Mul
            Console.WriteLine(a); //MuHello, World!
        }
    }
}
