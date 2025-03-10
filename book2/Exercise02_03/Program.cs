namespace Exercise02_03
{
    internal delegate char MakeLetter();
    class Text
    {
        public string text;
        private MakeLetter caller;
        public Text(string text, bool firstOrLast)
        {
            this.text = text;
            if (firstOrLast)
            {
                /*
                caller = delegate ()
                {
                    return text[0];
                };
                */
                caller = new MakeLetter( 
                    delegate ()
                        {
                            return text[0];
                        }
                );
            }
            else
            {
                caller = () => text[text.Length-1];
            }
        }
        public MakeLetter GetCaller => caller; // Сокращённая форма лямбда только get.
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Text a = new Text("Привет", true);
            Text b = new Text("Привет", false);
            Console.Write(a.GetCaller());
            Console.Write(b.GetCaller());
        }
    }
}
