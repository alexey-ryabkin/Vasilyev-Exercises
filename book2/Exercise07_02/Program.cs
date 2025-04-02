namespace Exercise07_02
{
    internal class Program
    {
        static void ShiftLeftBy1<T>(T[] arg)
        {
            int l = arg.Length;
            T last = arg[l - 1];
            for (int i = l - 1; i >= 1; i--)
            {
                arg[i] = arg[i - 1];
            }
            arg[0] = last;
        }
        static void p<T>(T[] arg)
        {
            Console.Write("|");
            for (int i = 0; i < arg.Length; i++)
            {
                Console.Write("{0}|", arg[i]);
            }
            Console.WriteLine();
        }
        static void Test<T>(T[] arg)
        {
            p(arg);
            ShiftLeftBy1(arg);
            p(arg);
        }
        static void Main(string[] args)
        {
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++) a[i] = i;
            char[] b = new char[10];
            for (int i = 0; i < b.Length; i++) b[i] = (char)('A' + i);
            string c = "Testing";
            Test(a);
            Test(b);
            Test<char>(c.ToCharArray());
            Test("asdf".ToCharArray());
            p(a);
            p(b);
            Console.WriteLine(c);
            Console.WriteLine("asdf");
        }
    }
}
