namespace Exercise01_10
{
    abstract class AbClass
    {
        public abstract int Value { get; set; }
        public abstract int this[int index] { get; set; }
        public abstract void Show();
    }
    interface IFirst
    {
        public abstract int Value { get; set; }
        public abstract int this[int index] { get; set; }
        public abstract void Show();
    }
    interface ISecond
    {
        public abstract int Value { get; set; }
        public abstract int this[int index] { get; set; }
        public abstract void Show();
    }
    class MyClass:AbClass, IFirst, ISecond
    {
        private int _val;
        public MyClass(int val)
        {
            _val = val;
        }
        public override int Value 
        {
            get { return _val; }
            set { _val = value; } 
        }
        public override int this[int index] 
        {
            get { return _val; }
            set { _val = value; }
        }
        public override void Show()
        {
            Console.WriteLine("Основная реализация " + _val);
        }
        int IFirst.Value 
        {
            get { Show(); return _val; }
            set { _val = value; Show(); } 
        }
        int IFirst.this[int index] 
        {
            get { Show(); return _val; }
            set { _val = value; Show(); }
        }
        void IFirst.Show()
        {
            Console.WriteLine("IFirst " + _val);
        }
        int ISecond.Value 
        {
            get { Show(); return _val; }
            set { _val = value; Show(); } 
        }
        int ISecond.this[int index] 
        {
            get { Show(); return _val; }
            set { _val = value; Show(); }
        }
        void ISecond.Show()
        {
            Console.WriteLine("ISecond " + _val);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass c = new MyClass(50);
            AbClass a = c;
            IFirst f = c;
            ISecond s = c;
            Console.WriteLine(a.Value);
            a.Value = 60;
            Console.WriteLine(a[0]);
            a[100] = 70;
            a.Show();
            Console.WriteLine();
            Console.WriteLine(f.Value);
            f.Value = 60;
            Console.WriteLine(f[0]);
            f[100] = 70;
            f.Show();
            Console.WriteLine();
            Console.WriteLine(s.Value);
            s.Value = 60;
            Console.WriteLine(s[0]);
            s[100] = 70;
            s.Show();
        }
    }
}
