namespace Exercise07_01
{
    internal class MyClass
    {
        public int num;
        public MyClass(int x) { num = x; }
        public override string ToString()
        {
            return num.ToString();
        }
    }
    internal class Program
    {
        static void Switch<T>(ref T First, ref T Second)
        {
            (First, Second) = (Second, First);
        }
        static void Main(string[] args)
        {
            int a = 1, b = 2;
            char c = 'c', d = 'd';
            MyClass e = new MyClass(3), f = new MyClass(4);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", a, b, c, d, e, f); //1, 2, c, d, 3, 4
            Switch(ref a, ref b);
            Switch(ref c, ref d);
            Switch(ref e, ref f);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", a, b, c, d, e, f); //2, 1, d, c, 4, 3
         }
    }
}
