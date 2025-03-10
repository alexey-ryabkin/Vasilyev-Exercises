using System.Runtime.CompilerServices;

namespace Exercise01_01
{
    abstract class BaseClass
    {
        protected int[] ints;
        public BaseClass(int size)
        {
            ints = new int[size];
        }
        public int Length
        {
            get
            {
                return ints.Length;
            }
        }
        public abstract void Show();
        public abstract int this[int index] { get; set; }
    }
    class DerivedClass: BaseClass
    {
        public DerivedClass(int size) : base(size) { }
        public override void Show()
        {
            string result = string.Empty;
            foreach(int integer in ints)
            {
                result += "|" + integer.ToString();
            }
            result += "|";
            Console.WriteLine(result);
        }
        public override int this[int index]
        {
            get
            {
                return ints[index];
            }
            set
            {
                ints[index] = value;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass a = new DerivedClass(10);
            a.Show();//|0|0|0|0|0|0|0|0|0|0|
            Console.WriteLine(a.Length);//10
            a[0] = 13;
            a[1] = 89;
            Console.WriteLine(a[1]);//88
            a.Show();//|14|88|0|0|0|0|0|0|0|0|
        }
    }
}
