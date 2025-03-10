using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace Exercise08_05
{
    class MyClass
    {
        public int a;
        public char b;

        public MyClass()
        {
            Random rng = new Random();
            a = rng.Next(50, 101);
            b = (char)rng.Next(50, 101);
        }

        public override string ToString()
        {
            return a.ToString() + ", " + b.ToString() + " = " + ((int)b).ToString() + " diff = " + Math.Abs(a - b);
        }

        public static bool operator true (MyClass obj)
        {
            int diff = Math.Abs(obj.a - (int)obj.b);
            return diff <= 10;
        }

        public static bool operator false (MyClass obj)
        {
            int diff = Math.Abs(obj.a - (int)obj.b);
            return diff > 10;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass[] a = new MyClass[12];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new MyClass();
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]) Console.WriteLine(a[i]);
            }
        }
    }
}
