namespace Exercise09_03
{
    class nums
    {
        private int[] numbs;

        public nums()
        {
            Random rng = new Random();
            numbs = new int[rng.Next(5)];
            for (int i = 0; i < numbs.Length; i++)
            {
                numbs[i] = rng.Next(11);
            }
            Console.WriteLine("Создан элемент " + this);
        }

        public override string ToString()
        {
            string a = string.Empty;
            for (int i = 0; i < numbs.Length; i++)
            {
                a += numbs[i] + " ";
            }
            return a;
        }

        public int sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < numbs.Length; i++)
                {
                    sum += this[i];
                }
                return sum;
            }
        }

        public int this[int index]
        {
            get
            {
                return numbs[index];
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            nums a = new nums();
            Console.WriteLine(a.sum);
            a = new nums();
            Console.WriteLine(a.sum);
            a = new nums();
            Console.WriteLine(a.sum);
        }
    }
}
