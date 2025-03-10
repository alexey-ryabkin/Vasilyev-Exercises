using System.Runtime.InteropServices.Marshalling;

namespace Exercise01_09
{
    abstract class AbLetters
    {
        protected char[] letters;
        public AbLetters(string letters)
        {
            /*
            this.letters = new char[letters.Length];
            for (int i = 0; i < letters.Length; i++)
            {
                this.letters[i] = letters[i];
            }
            */
            //Вспомнил
            this.letters = letters.ToCharArray();
        }
        public char GetLetter(int index)
        {
            //if (letters.Length == 0) { throw new ArgumentOutOfRangeException(); }
            return letters[index];
        }
        abstract public void SetLetter(int index, char value);
        public void SetLetter(char value, int index)
        {
            SetLetter(index, value);
        }
    }
    interface ILetters
    {
        void SetLetter(string letters);
        char this[int index] { get; set; }
    }
    class Letters:AbLetters, ILetters
    {
        public Letters(string letters) : base(letters)
        {
        }
        public override void SetLetter(int index, char value)
        {
            letters[index] = value;
        }
        public void SetLetter(string letters)
        {
            this.letters = letters.ToCharArray();
        }
        public char this[int index]
        {
            get
            {
                return letters[index];
            }
            set
            {
                letters[index] = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Long text";
            Letters l = new Letters(input);
            AbLetters a = l;
            ILetters i = l;
            Console.WriteLine(l.GetLetter(0));
            //Console.WriteLine(a.GetLetter(10));
            i.SetLetter("Text");
            a.SetLetter(1, 'a');
            a.SetLetter('i', 3);
            l[3] = 'I';
            Console.WriteLine(i[0].ToString() + i[1] + i[2] + i[3]);
        }
    }
}
