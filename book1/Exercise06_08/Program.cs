using System.Security.Cryptography;

namespace Exercise06_08
{
    class MyClass
    {
        private static int a = 0;

        public static void Increment()
        {
            Console.WriteLine("Значение до увеличения: {0}", MyClass.a);
            MyClass.a++;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                MyClass.Increment();
            }
        }
    }
}
