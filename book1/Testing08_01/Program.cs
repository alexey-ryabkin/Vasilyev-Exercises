namespace Testing08_01
{
    class Myclass
    {
        public int Id;
        public Myclass(int Id)
        {
            this.Id = Id;
        }

        public static Myclass operator +(Myclass input1, int input2)
        {
            return new Myclass(input1.Id + input2);
        }

        public static Myclass operator +(Myclass input1, Myclass2 input2)
        {
            return new Myclass(input1.Id + input2.Id);
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
    class Myclass2
    {
        public int Id;
        public Myclass2(int Id)
        {
            this.Id = Id;
        }

        public static Myclass operator +(Myclass input1, Myclass2 input2)
        {
            return new Myclass(input1.Id + input2.Id);
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Myclass obj = new Myclass(5);
            Myclass2 obj2 = new Myclass2(6);
            Console.WriteLine(obj + 8);
            Console.WriteLine(obj2 + 8);
            Console.WriteLine(obj + obj2);
        }
    }
}
