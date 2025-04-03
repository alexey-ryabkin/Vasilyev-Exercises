using System.Xml.Serialization;

namespace Exercise07_06
{
    internal class Program
    {
        static T? Max<T>(T[] items) where T : IComparable
        {
            if (items.Length == 0)
            {
                return default;
            }
            T current = items[0];
            for (int i = 0; i < items.Length - 1; i++)
            {
                if (current.CompareTo(items[i + 1]) < 0) current = items[i + 1];
            }
            return current;
        }
        static void Test()
        {
            Random random = new Random();
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++) 
            {
                a[i] = random.Next(200);
            }
            foreach (int i in a) Console.Write("{0} ", i);
            Console.WriteLine();
            Console.WriteLine("{0} {1} {2}", Max(a), a.Max(), Max(a) == a.Max());
        }
        static void Test1()
        {
            Random random = new Random();
            char[] a = new char[10];
            for (int i = 0; i < a.Length; i++) 
            {
                a[i] = (char)random.Next(200);
            }
            foreach (int i in a) Console.Write("{0} ", i);
            Console.WriteLine();
            Console.WriteLine("{0} {1} {2}", Max(a), a.Max(), Max(a) == a.Max());
        }
        static void Main(string[] args)
        {
            Test1();
        }
    }
}
