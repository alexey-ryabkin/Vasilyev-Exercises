namespace Testing08_02
{
    class Data
    {
        public int Id;

        public Data(int a)
        {
            Id = a;
        }

        public static Data operator ++(Data obj)
        {
            obj.Id += 1;
            //obj = new Data(obj.Id + 1);
            // Сюда передаётся техническая копия ссылки на объект!!!!!!!!
            return new Data(8);
        }

        public override string ToString()
        {
            return Id.ToString();
        }

        public void Increment()
        {
            Id = Id + 1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Data a = new Data(5);
            Console.WriteLine(a + " " + a.GetHashCode());
            Console.WriteLine(a++ + " " + a.GetHashCode());
            Console.WriteLine(a + " " + a.GetHashCode());
            Console.WriteLine(++a + " " + a.GetHashCode());
            Console.WriteLine(a + " " + a.GetHashCode());
            Console.WriteLine();
            int b = 5;
            Console.WriteLine(b + " " + b.GetHashCode());
            Console.WriteLine(++b + " " + b.GetHashCode());
            Console.WriteLine(b++ + " " + b.GetHashCode());
            Console.WriteLine(b + " " + b.GetHashCode());
            Console.WriteLine();
            Data c = new Data(5);
            Console.WriteLine(c + " " + c.GetHashCode());
            c.Increment();
            Console.WriteLine(c + " " + c.GetHashCode());
            c.Increment();
            Console.WriteLine(c + " " + c.GetHashCode());
            Console.WriteLine();
            Data d = new Data(5);
            Console.WriteLine(d + " " + d.GetHashCode());
            d++;
            Console.WriteLine(d + " " + d.GetHashCode());
            ++d;
            Console.WriteLine(d + " " + d.GetHashCode());
        }
    }
}
