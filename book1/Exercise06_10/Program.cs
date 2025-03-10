namespace Exercise06_10
{
    class RyabTrig
    {
        private static int n = 2000;
        public const double pi = 3.141592653589793238462643383279;

        public static double cos(double angle)
        {
            double counter = 1, sum = 1;
            for (int i = 0; i < n; i++)
            {
                counter *= -angle * angle / ((2 * i + 2) * (2 * i + 1));
                sum += counter;
            }
            Console.WriteLine("Использован статический метод для подсчёта косинуса. Cos({0}) = {1}", angle, sum);
            return sum;
        }
        public static double sh(double angle)
        {
            double counter = angle, sum = angle;
            for (int i = 0; i < n; i++)
            {
                counter *= angle * angle / (4 * i * i + 10 * i + 6);
                sum += counter;
                //Console.WriteLine(counter);
            }
            Console.WriteLine("Использован статический метод для подсчёта гиперболического синуса. sh({0}) = {1}", angle, sum);
            return sum;
        }
        public static double ch(double angle)
        {
            double counter = 1, sum = 1;
            for (int i = 0; i < n; i++)
            {
                counter *= angle * angle / (4 * i * i + 6 * i + 2);
                sum += counter;
            }
            Console.WriteLine("Использован статический метод для подсчёта гиперболического косинуса. ch({0}) = {1}", angle, sum);
            return sum;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            a = RyabTrig.cos(0);
            Console.WriteLine(Math.Cos(0));
            a = RyabTrig.cos(RyabTrig.pi/4);
            Console.WriteLine(Math.Cos(RyabTrig.pi / 4));
            a = RyabTrig.cos(RyabTrig.pi/2);
            Console.WriteLine(Math.Cos(RyabTrig.pi / 2));
            a = RyabTrig.cos(RyabTrig.pi/4 * 3);
            Console.WriteLine(Math.Cos(RyabTrig.pi / 4 * 3));
            a = RyabTrig.cos(RyabTrig.pi);
            Console.WriteLine(Math.Cos(RyabTrig.pi));
            a = RyabTrig.sh(0);
            Console.WriteLine(Math.Sinh(0));
            a = RyabTrig.sh(RyabTrig.pi/4);
            Console.WriteLine(Math.Sinh(RyabTrig.pi / 4));
            a = RyabTrig.sh(RyabTrig.pi/2);
            Console.WriteLine(Math.Sinh(RyabTrig.pi / 2));
            a = RyabTrig.sh(RyabTrig.pi/4 * 3);
            Console.WriteLine(Math.Sinh(RyabTrig.pi / 4 * 3));
            a = RyabTrig.sh(RyabTrig.pi);
            Console.WriteLine(Math.Sinh(RyabTrig.pi));
            a = RyabTrig.ch(0);
            Console.WriteLine(Math.Cosh(0));
            a = RyabTrig.ch(RyabTrig.pi/4);
            Console.WriteLine(Math.Cosh(RyabTrig.pi / 4));
            a = RyabTrig.ch(RyabTrig.pi/2);
            Console.WriteLine(Math.Cosh(RyabTrig.pi / 2));
            a = RyabTrig.ch(RyabTrig.pi/4 * 3);
            Console.WriteLine(Math.Cosh(RyabTrig.pi / 4 * 3));
            a = RyabTrig.ch(RyabTrig.pi);
            Console.WriteLine(Math.Cosh(RyabTrig.pi));
        }
    }
}
