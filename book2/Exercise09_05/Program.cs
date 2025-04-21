namespace Exercise09_05
{
    internal class Program
    {
        public static bool DatesEqualApprox(DateTime first, DateTime second, TimeSpan diffBorder)
        {
            if (first > second) (first, second) = (second, first);
            TimeSpan diff = second - first;
            if (diffBorder >= diff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Test()
        {
            for (int i = 0; i < 10; i++)
            {
                Random rng = new Random();
                DateTime a = DateTime.Now;
                DateTime b = new DateTime(rng.NextInt64(new DateTime(2025, 04, 18).Ticks, new DateTime(2025,04,22).Ticks));
                TimeSpan c = new TimeSpan(rng.NextInt64(0, 86400 * 10000000L));
                Console.WriteLine("{0, -21}{1, -21}{2, -21}{3, -5}", a, b, c, DatesEqualApprox(a, b, c));
            }
        }
        static void Main(string[] args)
        {
            Test();
        }
    }
}
