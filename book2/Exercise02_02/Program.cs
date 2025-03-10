using static System.Net.Mime.MediaTypeNames;

namespace Exercise02_02
{
    internal delegate void Setter(char letter);
    class MyLetter
    {
        private char letter;
        public MyLetter(char letter)
        {
            SetLetter(letter);
        }
        public void SetLetter(char letter)
        {
            this.letter = letter;
        }
        public override string ToString()
        {
            //return String.Format("Объект MyLetter со значением {0}.", letter);
            return String.Format(letter.ToString());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Лупа и Пупа";
            int l = text.Length;
            MyLetter[] letters = new MyLetter[l];
            for (int i = 0; i < l; i++)
            {
                letters[i] = new MyLetter(text[i]);
            }
            // Создание экземпляра делегата, чтобы его можно было передать в мой метод
            Setter del = new Setter(a => { });
            for (int i = 0; i < l; i++) del += letters[i].SetLetter;
            print(letters); // Лупа и Пупа
            del('b');
            print(letters); // bbbbbbbbbbb
        }
        static MyLetter[] CreateLetters(string text)
        {
            int l = text.Length;
            MyLetter[] obj = new MyLetter[l];
            for (int i = 0; i < l; i++)
            {
                obj[i] = new MyLetter(text[i]);
            }
            return obj;
        }
        static void SetSetter(MyLetter[] objs, Setter del) // Эта вещь работает с технической копией letters, поэтому для её работы нужно было бы возвращать letters.
        {
            int l = objs.Length;
            for (int i = 0; i < l; i++) del += objs[i].SetLetter;
        }
        static void print(MyLetter[] a)
        {
            foreach (MyLetter b in a) Console.Write(b);
            Console.WriteLine();
        }
    }
}
