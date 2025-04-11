// Листинг 7.13
namespace Testing07_02
{
    class Alpha
    {
        public int code;
        public override string ToString()
        {
            return "Alpha: " + code;
        }
    }
    class Bravo : Alpha
    {
        public string text;
        public override string ToString()
        {
            return "Bravo: " + code + " и " + text;
        }
    }
    class MyClass<X, Y>
        where X : class, new()
        //where Y : X, new()
        where Y : X // Да, не пропускает компилятор, хотя new() явно есть, его не может не быть
    {
        public X first;
        public Y second;
        public MyClass()
        {
            first = new X();
            second = new Y();
        }
        public override string ToString()
        {
            return "MyClass ->|" + first + "|" + second + "|";
        }
    }
    class MultiGenRestDemo
    {
        static void Main()
        {
            MyClass<Alpha, Bravo> obj = new MyClass<Alpha, Bravo>();
            obj.first.code = 100;
            obj.second.code = 200;
            obj.second.text = "text";
            Console.WriteLine(obj);
        }
    }
}
