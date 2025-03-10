namespace Exercise10_04
{
    class Alpha
    {
        public int num;
        public Alpha(int num)
        {
            this.num = num;
        }
        public void set(int num)
        {
            this.num = num;
        }
        public override string ToString()
        {
            return System.String.Format("Класс Alpha.\nnum = {0}\n\n", num);
        }
        ~Alpha()
        {
            Console.WriteLine("Умер класс Alpha");
        }
    }
    class Beta: Alpha
    {
        public char letter;
        public Beta(int num, char letter) : base(num)
        {
            this.letter = letter;
        }
        public void set(int num, char letter)
        {
            this.letter = letter;
            set(num);
        }
        public override string ToString()
        {
            return System.String.Format("Класс Beta.\nnum = {0}\nletter = {1}\n\n", num, letter);
        }
        ~Beta()
        {
            Console.WriteLine("Умер класс Beta");
        }
    }
    class Gamma: Beta
    {
        public string text;
        public Gamma(int num, char letter, string text): base(num, letter)
        {
            this.text = text;
        }
        public void set(int num, char letter, string text)
        {
            this.num = num;
            this.letter = letter;
            this.text = text;
        }
        public override string ToString()
        {
            return System.String.Format("Класс Gamma.\nnum = {0}\nletter = {1}\ntext = {2}\n\n", num, letter, text);
        }
        ~Gamma()
        {
            Console.WriteLine("Умер класс Gamma");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Alpha a = new Alpha(10);
            Console.Write(a);
            a.set(50);
            Console.Write(a);
            Beta b = new Beta(11, 'b');
            Console.Write(b);
            b.set(51, 'B');
            Console.Write(b);
            Gamma g = new Gamma(12, 'g', "long words");
            Console.Write(g);
            g.set(52, 'G', "LONG WORDS");
            Console.Write(g);

            Console.WriteLine(new Alpha(49));
            Console.WriteLine(new Beta(48, 'I'));
            Console.WriteLine(new Gamma(47, 'J', "Die"));
            new Gamma(47, 'J', "Die");
        }
    }
}
