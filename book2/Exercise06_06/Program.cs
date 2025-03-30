using System.Runtime.Serialization.Formatters;

namespace Exercise06_06
{
    internal class Program
    {
        static int? FindMax(int[] ints)
        {
            if (ints.Length == 0) return null;
            int current = ints[0];
            for (int i = 0; i < ints.Length; i++)
            {
                if (current < ints[i]) current = ints[i];
            }
            return current;
        }
        static int? FindMin(int[] ints)
        {
            if (ints.Length == 0) return null;
            int current = ints[0];
            for (int i = 0; i < ints.Length; i++)
            {
                if (current > ints[i]) current = ints[i];
            }
            return current;
        }
        static void Main(string[] args)
        {
            Random rng = new Random();
            int[] ints = new int[rng.Next(5,11)];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rng.Next(-100, 101);
                Console.Write("{0} ", ints[i]);
            }
            Console.WriteLine();
            ThreadStart tSMax = new ThreadStart(
                delegate() 
                { 
                    Console.WriteLine("Max = {0}", FindMax(ints)); 
                }
            );
            ThreadStart tSMin = new ThreadStart(
                delegate() 
                { 
                    Console.WriteLine("Min = {0}", FindMin(ints)); 
                }
            );
            Thread tMax= new Thread(tSMax);
            Thread tMin= new Thread(tSMin);
            tMax.Start();
            tMin.Start();
            if (tMax.IsAlive) tMax.Join();
            if (tMin.IsAlive) tMin.Join();
            Console.WriteLine("Выполнение программы завершено.");
        }
    }
}
