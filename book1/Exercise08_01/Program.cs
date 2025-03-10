using System.Numerics;

namespace Exercise08_01
{
    class MyClass
    {
        public char a;
        public MyClass(char a)
        {
            this.a = a;
        }
        public static MyClass operator ++ (MyClass obj)
        {
            obj.a++;
            return obj;
        }
        public static MyClass operator -- (MyClass obj)
        {
            obj.a--;
            return obj;
        }
        public static MyClass operator + (MyClass obj, int number)
        {
            return new MyClass((char)(obj.a + number));
        }
        public static MyClass operator + (int number, MyClass obj)
        {
            return obj + number;
        }
        public static int operator - (MyClass obj, int number)
        {
            return obj.a - number;
        }
        public static int operator - (int number, MyClass obj)
        {
            return number - obj.a;
        }
        public override string ToString()
        {
            return a.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass((char)1);
            Console.WriteLine(obj + ", " + (int)obj.a + ", " + obj.GetHashCode());
            obj--;
            obj--;
            Console.WriteLine(obj + ", " + (int)obj.a + ", " + obj.GetHashCode());
            obj++;
            Console.WriteLine(obj + ", " + (int)obj.a + ", " + obj.GetHashCode());
            Console.WriteLine(obj + 5);
            Console.WriteLine(obj + ", " + (int)obj.a + ", " + obj.GetHashCode());
            Console.WriteLine(5 + obj);
            Console.WriteLine(obj + ", " + (int)obj.a + ", " + obj.GetHashCode());
            Console.WriteLine(obj - 5);
            Console.WriteLine(obj + ", " + (int)obj.a + ", " + obj.GetHashCode());
            Console.WriteLine(5 - obj);
            Console.WriteLine(obj + ", " + (int)obj.a + ", " + obj.GetHashCode());
        }
    }
}
