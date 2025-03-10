namespace Exercise01_03
{
    interface Sum
    {
        int Sum();
    }
    class EvenSum : Sum
    {
        int number;
        public EvenSum(int number)
        {
            this.number = number;
        }
        public int Sum()
        {
            return (number - 1) * number;
        }
    }
    class OddSum : Sum
    {
        int number;
        public OddSum(int number)
        {
            this.number = number;
        }
        public int Sum()
        {
            return number * number;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test(0);
            Test(5);
            Test(9);
        }
        static void Test(int n)
        {
            EvenSum a = new EvenSum(n);
            OddSum b = new OddSum(n);
            Sum c = a;

            Console.WriteLine("Even(n) = {0}", a.Sum());
            Console.WriteLine("Sum(n) = {0}", c.Sum());
            Console.WriteLine("Odd(n) = {0}", b.Sum());
            c = b;
            Console.WriteLine("Sum(n) = {0}", c.Sum());
        }
    }
}
