namespace Exercise06_10
{
    internal class Program
    {
        static bool working = true;
        static double result = 1;
        static void Calculate()
        {
            int n = 2;
            while (working)
            {
                double a = (n * n * n - 1) / (double)(n * n * n + 1);
                result *= a;
                n++;
                //Console.WriteLine("{0,5}, {1:0.0000000}, {2:0.0000000}", n, a, result);
            }
        }
        static void Main(string[] args)
        {
            Thread calculation = new Thread(Calculate);
            calculation.Start();
            Random rng = new Random();
            for (int i = 0; i < 1000; i++)
            {
                //Console.WriteLine("Основной поток делает что-то полезное: {0,3}", rng.Next(i));
            }
            Thread.Sleep(500);
            working = false;
            Console.WriteLine("Вычисленное значение: {0:0.0000000}", result);
            Console.WriteLine("Целевое значение:     {0:0.0000000}", 2/(double)3);
        }//14337
    }
}
