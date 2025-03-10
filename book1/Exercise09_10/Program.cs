using System;

namespace Exercise09_10
{
    class Text
    {
        public string[] text;

        public Text(string text)
        {
            this.text = text.Split();
        }

        public override string ToString()
        {
            return string.Join(", ", text);
        }

        public string this[int index]
        {
            get
            {
                if (index < 0) index = text.Length + index % text.Length;
                if (index >= text.Length) index = index % text.Length;
                return text[index];
            }
            set
            {
                if (index < 0) index = text.Length + index % text.Length;
                if (index >= text.Length) index = index % text.Length;
                text[index] = value;
            }
        }

        public char this[int word, int letter]
        {
            get
            {
                if (word < 0) word = text.Length + word % text.Length;
                if (word >= text.Length) word = word % text.Length;
                if (letter < 0) letter = text[word].Length + letter % text.Length;
                if (letter >= text[word].Length) letter = letter % text[word].Length;
                return text[word][letter];
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Text a = new Text("""
                Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                """);
            Console.WriteLine(a);
            a[8] = "Крокодил";
            a[1] = "Гена";
            a[-1] = "Чебурашка";
            Console.WriteLine(a);
            Console.WriteLine(a[0]);
            Console.WriteLine(a[8]);
            Console.WriteLine(a[-1]);
            Console.WriteLine(a[0, 0]);
            Console.WriteLine(a[-1, 0]);
            Console.WriteLine(a[0, -1]);
            Console.WriteLine(a[-1, -1]);
            Console.WriteLine(a[8, 0]);
            Console.WriteLine(a[0, 8]);
            Console.WriteLine(a[8, 8]);
        }
    }
}
