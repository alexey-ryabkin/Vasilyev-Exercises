namespace Exercise07_03
{
    internal class MyClass<T>
    {
        private T obj;
        public MyClass(T obj)
        {
            this.obj = obj;
        }
        public T Value
        {
            get
            {
                return obj;
            }
            set
            {
                obj = value;
            }
        }
        public override string ToString()
        {
            return "MyClass: " + obj.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> a = new MyClass<int>(10);
            Console.WriteLine(a);
            a.Value = 0;
            Console.WriteLine(a.Value);
            MyClass<Char> b = new MyClass<char>('a');
            b.Value = (char)65;
            Console.WriteLine(b.Value);
        }
    }
}
