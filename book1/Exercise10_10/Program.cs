namespace Exercise10_10
{
    class SuperTallsH
    {
        protected int[] heigths;
        public SuperTallsH(int[] args)
        {
            heigths = new int[args.Length];
            args.CopyTo(heigths, 0);
        }
        public int this[int index]
        {
            get
            {
                return heigths[index];
            }
            set
            {
                heigths[index] = value;
            }
        }
        public int Club
        {
            get
            {
                return heigths.Length;
            }
        }
        public void p()
        {
            string temp = String.Empty;
            for (int i = 0; i < heigths.Length; i++)
            {
                temp += heigths[i] + " ";
            }
            temp += "\n";
            Console.WriteLine(temp);
        }
    }
    class SuperTalls: SuperTallsH
    {
        protected char[] grades;
        public SuperTalls(int[] args, char[] grades) : base(args)
        {
            this.grades = grades;
        }
        public char this[char index]
        {
            get
            {
                return grades[index - 'a'];
            }
            set
            {
                grades[index - 'a'] = value;
            }
        }
        public int[] Club
        {
            get
            {
                return [heigths.Length,grades.Length];
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hs = {150, 1500, 1700, 2100, 100, 800};
            SuperTallsH a = new SuperTallsH(hs);
            a.p();
            Console.WriteLine("1500 = {0}", a[1]);
            a[1] = 8756;
            Console.WriteLine("8756 = {0}", a[1]);
            hs[1] = 0;
            Console.WriteLine("0 ≠ {0}", a[1]);
            Console.WriteLine("Club size = {0}", a.Club);

            char[] gs = {'a', 'b', 'c', 'd', 'e', 'f'};
            SuperTalls b = new SuperTalls(hs, gs);
            b.p();
            Console.WriteLine("\'b\' = {0}", b['b']);
            b['b'] = 'z';
            Console.WriteLine("\'z\' = {0}", b['b']);
            gs[2] = '0';
            Console.WriteLine("\'0\' ≠ {0}", b['b']);
            Console.Write("Club size = {0}, {1}", b.Club[0], b.Club[1]);
        }
    }
}
