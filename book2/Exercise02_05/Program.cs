namespace Exercise02_05
{
    internal delegate int DFib();
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = b = 1;
            DFib FibMaker = () =>
            {
                (a, b) = (b, a + b);
                return a;
            };
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(FibMaker());
            }
        }
    }
}
