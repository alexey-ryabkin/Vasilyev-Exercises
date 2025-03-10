namespace Exercise02_08
{
    internal delegate int Calculate(int number);
    internal class Program
    {
        static Calculate CombineMethods(Calculate first, Calculate second)
        {
            return number => second(first(number));
        }
        static int Add5(int number)
        {
            return number + 5;
        }
        static int Double(int number)
        {
            return 2 * number;
        }
        static int Test0(Calculate meth)
        {
            Random random = new Random();
            int fails = 0;
            for (int i = 0; i < 1000; i++)
            {
                int j = random.Next(-10000, 10000);
                int a = meth(j);
                int b = Double(Add5(j));
                if (a != b)
                {
                    fails++;
                    Console.WriteLine("{0} != {1}", a, b);
                }
                else
                {
                    Console.WriteLine("{0} = {1}", a, b);
                }
            }
            Console.WriteLine("Ошибок: {0}", fails);
            return fails;
        }
        static int Test1(Calculate meth)
        {
            Random random = new Random();
            int fails = 0;
            for (int i = 0; i < 1000; i++)
            {
                int j = random.Next(-10000, 10000);
                int a = meth(j);
                int b = Add5(Double(j));
                if (a != b)
                {
                    fails++;
                    Console.WriteLine("{0} != {1}", a, b);
                }
                else
                {
                    Console.WriteLine("{0} = {1}", a, b);
                }
            }
            Console.WriteLine("Ошибок: {0}", fails);
            return fails;
        }
        static void Main(string[] args)
        {
            Test0(CombineMethods(Add5, Double));
            Console.ReadLine();
            Test1(CombineMethods(Add5, Double));
            Console.ReadLine();
            Test0(CombineMethods(Double, Add5));
            Console.ReadLine();
            Test1(CombineMethods(Double, Add5));
        }
    }
}
