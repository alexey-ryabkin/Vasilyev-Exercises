namespace Exercise01_07
{
    interface INumber
    {
        int Number { get; set; }
        void Show();
    }
    interface IString
    {
        string Text { get; set; }
        void Show();
    }
    class Obj:INumber, IString
    {
        private int _num;
        private string _text;
        public Obj(int num, string text)
        {
            _num = num;
            _text = text;
        }
        public int Number
        {
            get
            {
                return _num;
            }
            set
            {
                _num = value;
            }
        }
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        /*
        public void show()
        {
            Console.WriteLine("Number: " + _num);
            Console.WriteLine("Text: " + _text);
            Console.WriteLine();
        }
        */
        void INumber.Show()
        {
            Console.WriteLine("Number: " + _num);
            Console.WriteLine();
        }
        void IString.Show()
        {
            Console.WriteLine("Text: " + _text);
            Console.WriteLine();
        }
        public void Show()
        {
            Console.WriteLine("Number: " + _num);
            Console.WriteLine("Text: " + _text);
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Obj a = new Obj(50, "Hello world!");
            INumber n = a;
            IString s = a;
            a.Show();
            n.Show();
            s.Show();
            n.Number = 60;
            s.Text = "Пока мир!";
            a.Show();
            n.Show();
            s.Show();
        }
    }
}
