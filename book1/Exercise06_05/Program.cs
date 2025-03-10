namespace Exercise06_05
{
    class MyClass
    {
        private int a;

        public MyClass(int a = 0)
        {
            set(a);
        }

        public void set(int a)
        {
            if (a < 100) this.a = a;
            else this.a = 100;
        }

        public void set()
        {
            this.a = 0;
        }

        public int get() 
        {
            Console.WriteLine(this.a);
            return this.a;
        }
    }    
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            MyClass b = new MyClass(50);
            MyClass c = new MyClass(600);
            c.set();
            MyClass[] d = [a, b, c];
            foreach (MyClass i in d)
            {
                Console.WriteLine("От метода получено: {0}", i.get());
            }
        }
    }
}
