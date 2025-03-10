namespace Exercise10_07
{
    class Basic_ass_class
    {
        public string basic_string;
        public Basic_ass_class(string a = "text")
        {
            basic_string = a;
        }
        public virtual Developed_class develop()
        {
            Developed_class development = new Developed_class(basic_string, basic_string[0]);
            return development;
        }
        public void p()
        {
            Console.WriteLine(basic_string);
        }
    }
    class Developed_class: Basic_ass_class
    {
        public char developed_letter;
        public Developed_class(string basic_string, char letter): base()
        {
            this.basic_string = basic_string;
            developed_letter = letter;
        }
        public override Developed_class develop()
        {
            Developed_class development = new Developed_class(basic_string, developed_letter);
            return development;
        }
        public void p()
        {
            Console.WriteLine(basic_string + " " + developed_letter);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Basic_ass_class a = new Basic_ass_class();
            a.p();
            Developed_class b = a.develop(), c;
            b.p();
            c = b.develop();
            c.p();
            b.developed_letter = 'z';
            c.p();
            b.p();
        }
    }
}
