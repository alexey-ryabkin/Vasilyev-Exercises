using System.Diagnostics;

namespace Exercise04_03
{
    internal class Program
    {
        unsafe static void Test()
        {
            Console.WriteLine($"{Convert.ToString(-(int.MaxValue - 65535 -1), toBase: 2).PadLeft(32, '0'),32}");
            int test;
            int* testp = &test;
            byte* testpb = (byte*)testp;
            testpb[0] = 0;
            testpb[1] = 0;
            testpb[2] = 255;
            testpb[3] = 255;
            Console.WriteLine($"{Convert.ToString(test, toBase: 2).PadLeft(32, '0'),32}");
            Console.WriteLine(test);
            Console.WriteLine($"{Convert.ToString(65535, toBase: 2).PadLeft(32, '0'),32}");
            Console.WriteLine($"{Convert.ToString(-65536, toBase: 2).PadLeft(32, '0'),32}");
        }
        unsafe static void Main(string[] args)
        {
            int a, b, c;
            Random rng = new Random();
            a = rng.Next();
            b = rng.Next();
            int*
                ap = &a,
                bp = &b,
                cp = &c;
            char* 
                apc = (char*)&a,
                bpc = (char*)&b,
                cpc = (char*)&c;
            *cpc = *apc;
            cpc[1] = bpc[1];

            // Проверка через побитовые операции
            int test;
            test = (65535 & a) | (-65536 & b);
            Console.WriteLine(test == c ? "Программа посчитана верно" : "Программа посчитана неверно");
            //Console.WriteLine("a    = {0, 10} = {1, 32}", a, Convert.ToString(a, toBase: 2).PadLeft(32, '0'));
            //Console.WriteLine("b    = {0, 10} = {1, 32}", b, Convert.ToString(b, toBase: 2).PadLeft(32, '0'));
            Console.WriteLine("c    = {0, 10} = {1, 32}", c, Convert.ToString(c, toBase: 2).PadLeft(32, '0'));
            Console.WriteLine("test = {0, 10} = {1, 32}", test, Convert.ToString(test, toBase: 2).PadLeft(32, '0'));
        }
    }
}
