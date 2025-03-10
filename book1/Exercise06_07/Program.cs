namespace Exercise06_07
{
    class MyClass
    {
        public char symb;
        public string text;

        public void set(char a)
        {
            symb = a;
            Console.WriteLine("Использовано назначение символа {0}", a);
        }
        public void set(string a)
        {
            text = a;
            Console.WriteLine("Использовано назначение строки «{0}»", a);
        }
        public void set(char[] a)
        {
            if (a.Length == 1)
            {
                symb = a[0];
                Console.WriteLine("Использовано назначение массива из одного элемента «{0}»", symb);
            }
            else
            {
                text = "";
                foreach (char c in a) text += c;
                Console.WriteLine("Использовано назначение массива из не одного элемента «{0}»", text);
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();

            a.set('a');
            Console.WriteLine(a.symb + " " + a.text);
            a.set(['d', 'b', 'c']);
            Console.WriteLine(a.symb + " " + a.text);
            a.set(['e']);
            Console.WriteLine(a.symb + " " + a.text);
            a.set("string");
            Console.WriteLine(a.symb + " " + a.text);
        }
    }
}
