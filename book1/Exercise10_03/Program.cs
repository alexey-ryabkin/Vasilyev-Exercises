namespace Exercise10_03
{
    class cl1
    {
        public int[] ints;
        public cl1(int[] ints)
        {
            this.ints = new int[ints.Length];
            ints.CopyTo(this.ints, 0);
        }
        public override string ToString()
        {
            string res = string.Empty;
            for (int i = 0; i < ints.Length; i++)
            {
                res += ints[i].ToString();
                if (i != ints.Length - 1) res += ", ";
            }
            return res;
        }
    }
    class cl2: cl1
    {
        public char[] chars;
        public cl2(int[] ints, char[] chars): base(ints)
        {
            this.chars = new char[chars.Length];
            chars.CopyTo(this.chars, 0);
        }
        public override string ToString()
        {
            string res = string.Empty;
            res += base.ToString();//!!!!!!!!
            res += "\n";
            for (int i = 0; i < chars.Length; i++)
            {
                res += chars[i].ToString();
                if (i != chars.Length - 1) res += ", ";
            }
            return res;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Enumerable.Range(0,11).ToArray();
            cl1 class1 = new cl1(ints);
            Console.WriteLine(class1);
            ints[0] = 100000;
            Console.WriteLine(class1);
            Console.WriteLine(ints[0]);
            char[] chars = "text".ToArray();
            cl2 class2 = new cl2(ints, chars);
            Console.WriteLine(class2);
            ints[0] = 9999;
            chars[0] = 'z';
            Console.WriteLine(class2);
            Console.WriteLine(ints[0]);
            Console.WriteLine(chars[0]);
        }
    }
}
