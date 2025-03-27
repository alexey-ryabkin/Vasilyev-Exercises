namespace Exercise05_07
{
    class BadNums
    {
        private int[] num;
        public BadNums(int size)
        {
            num = new int[size];
            for (int i = 0; i < size; i++)
            {
                num[i] = i;
            }
        }
        public int this[int index]
        {
            get => num[index];
            set { num[index] = value; }
        }
        public override string ToString()
        {
            return num.Length.ToString();
        }
    }
    internal class Program
    {
        static int GetSize(BadNums obj)
        {
            int size = 0;
            while (true)
            {
                try
                {
                    int anon = obj[size];
                    size++;
                }
                catch
                {
                    break;
                }
            }
            return size;
        }
        static void Main(string[] args)
        {
            Random rng = new Random();
            Console.WriteLine("Any to test, DEL to exit");
            while (true)
            {
                //if (Console.ReadLine() == "0") Environment.Exit(0);
                if (Console.ReadKey(false).Key == ConsoleKey.Delete) Environment.Exit(0);
                BadNums obj = new BadNums(rng.Next(10000));
                Console.WriteLine(obj.ToString() == GetSize(obj).ToString());
            }
        }
    }
}
