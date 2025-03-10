using System;
using static System.Net.Mime.MediaTypeNames;

namespace Exercise10_05
{
    class Alpha
    {
        public char letter;
        public Alpha(char letter)
        {
            this.letter = letter;
            Console.WriteLine("Конструктор Alpha");
        }
        public Alpha(Alpha obj)
        {
            this.letter = obj.letter;
            Console.WriteLine("Создана копия Alpha");
        }
        public override string ToString()
        {
            return String.Format("Alpha, {0}", letter);
        }

    }
    class Beta: Alpha
    {
        public string text;
        public Beta(char letter, string text): base(letter)
        {
            this.text = text;
            Console.WriteLine("Конструктор Beta");
        }
        public Beta(Beta obj): base(obj)
        {
            this.text = obj.text;
            Console.WriteLine("Создана копия Beta");
        }
        public override string ToString()
        {
            return String.Format("Beta, {0}, {1}", letter, text);
        }
    }
    class Gamma: Beta
    {
        public int num;
        public Gamma(char letter, string text, int num): base(letter, text)
        {
            this.num = num;
            Console.WriteLine("Конструктор Gamma");
        }
        public Gamma(Gamma obj): base(obj)
        {
            num = obj.num;
            Console.WriteLine("Создана копия Gamma");
        }
        public override string ToString()
        {
            return String.Format("Gamma, {0}, {1}, {2}", letter, text, num);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Alpha a = new Alpha('1');
            Console.WriteLine(a);
            Alpha b = new Alpha(a);
            a.letter = '2';
            Console.WriteLine(a);
            Console.WriteLine(b);
            Beta c = new Beta('1', "111");
            Console.WriteLine(c);
            Beta d = new Beta(c);
            c.letter = '2';
            c.text = "222";
            Console.WriteLine(c);
            Console.WriteLine(d);
            Gamma e = new Gamma('1', "111", 1);
            Console.WriteLine(e);
            Beta f = new Beta(e);
            e.letter = '2';
            e.text = "222";
            e.num = 2;
            Console.WriteLine(e);
            Console.WriteLine(f);
        }
    }
}
