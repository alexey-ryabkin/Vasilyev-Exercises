using System.Threading;

namespace Exercise06_09
{
    internal class Program
    {
        static bool cancelled = false;
        static double result;
        static void CalculateSum()
        {
            int n = 1;
            double curVal = 1;
            result = 0;
            while (!cancelled)
            {
                curVal *= (2 * n + 2) / (double)(n * n);
                result += curVal;
                //Console.WriteLine("{0, 5}, {1, 5}, {2, 5}", n, curVal, result);
                n++;
                Thread.Sleep(1);
            }
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(CalculateSum);
            thread.Start();
            double target = 3 * Math.E * Math.E - 1;
            while (Math.Abs(target - result) > 0.00001) Thread.Sleep(1);
            cancelled = true;
            //Console.WriteLine();
            Console.WriteLine("Вычисленное значение: {0,10}", result);
            Console.WriteLine("Целевое значение:     {0,10}", target);
        }
    }
}
