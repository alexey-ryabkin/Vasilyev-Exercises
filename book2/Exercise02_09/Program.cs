namespace Exercise02_09
{
    internal delegate double Trinomial(double x);
    internal class Program
    {
        static Trinomial CreateTrinomial(double a, double b, double c)
        {
            return x => a * x * x + b * x + c;
        }
        public static void Test()
        {
            Random random = new Random();
            double a = random.NextDouble();
            double b = random.NextDouble();
            double c = random.NextDouble();
            double x = random.NextDouble();
            double answer = a * x * x + b * x + c;
            double test = CreateTrinomial(a, b, c)(x);
            Console.Write("{0:0.00}*{1:0.00}^2 + {2:0.00}*{1:0.00} + {3:0.00} = {4:0.00}", a, x, b, c, answer);
            if (test != answer) Console.Write(" != {0:0.00}", test);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++) Test();
        }
    }
}
