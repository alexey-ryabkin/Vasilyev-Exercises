using System.ComponentModel.DataAnnotations;

namespace Exercise10_02
{
    class Base
    {
        protected string a;
        public void set(string a)
        {
            this.a = a;
        }
        public virtual void set()
        {
            a = "default";
        }
        public Base(string a)
        {
            this.a = a;
        }
        public int length
        {
            get
            {
                return a.Length;
            }
        }
        public char this[int index]
        {
            get
            {
                return a[index];
            }
        }
        public override string ToString()
        {
            return a;
        }
    }
    class Derived: Base
    {
        public int b;
        public Derived(string a, int b): base(a)
        {
            this.b = b;
        }
        public override void set()
        {
            a = "new default";
            b = 0;
        }
        public void set(string a)
        {
            this.a = a;
        }
        public void set(int b)
        {
            this.b = b;
        }
        public void set(string a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void set(int b, string a)
        {
            set(a, b);
        }
        public override string ToString()
        {
            return a + " and " + b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Base obj0 = new Base("string");
            Console.WriteLine(obj0);
            obj0.set();
            Console.WriteLine(obj0);
            obj0.set("value");
            Console.WriteLine(obj0);
            Console.WriteLine(obj0.length);
            Console.WriteLine(obj0[2] + " = l");
            Derived obj1 = new Derived("name", 5);
            Console.WriteLine(obj1);
            obj1.set();
            Console.WriteLine(obj1);
            obj1.set("name0");
            Console.WriteLine(obj1);
            obj1.set(15);
            Console.WriteLine(obj1);
            obj1.set("name1", 30);
            Console.WriteLine(obj1);
            obj1.set(35, "name2");
            Console.WriteLine(obj1);
        }
    }
}
