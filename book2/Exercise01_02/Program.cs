namespace Exercise01_02
{
    abstract class BaseClass
    {
        protected string name;
        public BaseClass(string name)
        {
            this.name = name;
        }
        public abstract int Length { get; }
        public abstract char this[int index] { get; }
        public abstract void Set(string name);
        public abstract void Show();
    }
    class DerivedClass : BaseClass
    {
        public DerivedClass(string name) : base(name)
        {
        }
        public override int Length
        {
            get
            {
                return name.Length;
            }
        }
        public override char this[int index]
        {
            get
            {
                // Учёт отрицательных значений
                while (index < 0)
                {
                    index += this.Length;
                }
                // Учёт значений больше длины имени
                index %= this.Length;
                return name[index];
            }
        }
        public override void Set(string name)
        {
            this.name = name;
        }
        public override void Show()
        {
            Console.WriteLine(name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass a = new DerivedClass("BA/\\EPA");
            Console.WriteLine("7 = {0}", a.Length);
            Console.Write("A = {0}", a[-1]);
            Console.Write("A = {0}", a[1]);
            Console.Write("/ = {0}", a[9]);
            a.Set("Igor");
            a.Show();
        }
    }
}
