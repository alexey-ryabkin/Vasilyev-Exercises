using System.Xml.Serialization;

namespace Exercise07_07
{
    internal class Program
    {
        static void Sort<T>(T[] items) where T: IComparable
        {
            for (int i = items.Length - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (items[j].CompareTo(items[j + 1]) > 0) (items[j], items[j + 1]) = (items[j + 1], items[j]);
                }
                //foreach (T k in items) Console.Write("{0,5}", k);
                //Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[] ints = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rnd.Next(2000);
            }
            foreach (int i in ints) Console.Write("{0,5}", i);
            Console.WriteLine();
            Sort(ints);
            foreach (int i in ints) Console.Write("{0,5}", i);
            Console.WriteLine();
            string[] words = { "Привет", "привет", "Албания", "албания", "Бавария", "бавария", "Язгуль" };
            Sort(words);

            foreach (string i in words) Console.Write("{0} ", i);
            Console.WriteLine();
        }
    }
}
