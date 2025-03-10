namespace Exercise06_06
{
    class MyClass
    {
        int min, max;

        public MyClass(int a = 0, int b = 0)
        {
            if (b < a) (a, b) = (b, a);
            min = a; 
            max = b;
            Console.WriteLine("Использован конструктор с аргументами {0} и {1}.", a, b);
        }

        public void set(int a, int b)
        {
            if (b < a) (a, b) = (b, a);
            if (a < min) min = a;
            if (b > max) max = b;
            Console.WriteLine("Назначены значения {0} и {1}, остались значения {2} и {3}.", a, b, min, max);
        }
        public void set(int a)
        {
            if (a < min) min = a;
            if (a > max) max = a;
            Console.WriteLine("Назначено значение {0}, остались значения {1}, {2}.", a, min, max);
        }

        public void get()
        {
            Console.WriteLine(min + " < " + max);
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass(100, 50);
            a.get();
            a.set(0);
            a.get();
            a.set(80, 1000);
        }
    }
}
