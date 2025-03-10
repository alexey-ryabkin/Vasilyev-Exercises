namespace Exercise08_03
{
    class Numbers
    {
        private int number0;
        private int number1;

        public Numbers(int num0, int num1)
        {
            Random rng = new Random();
            number0 = rng.Next(num0);
            number1 = rng.Next(num1);
        }

        public static bool operator < (Numbers obj0, Numbers obj1)
        {
            int num0 = obj0.number0 * obj0.number0 + obj0.number1 * obj0.number1;
            int num1 = obj1.number0 * obj1.number0 + obj1.number1 * obj1.number1;

            return num0 < num1;
        }
        public static bool operator > (Numbers obj0, Numbers obj1)
        {
            return obj1 < obj0;
        }

        public override string ToString()
        {
            return number0.ToString() + " и " + number1.ToString();
            //return (number0 * number0 + number1 * number1).ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers[] a = new Numbers[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new Numbers(100,100);
                Console.WriteLine(a[i]);
            }
            for (int i = 0; i < a.Length - 1; i++)
            {
                Console.WriteLine("{0} < {1} = {2}", a[i], a[i + 1], a[i] < a[i + 1]); 
                Console.WriteLine("{0} > {1} = {2}", a[i], a[i + 1], a[i] > a[i + 1]); 
            }
        }
    }
}
