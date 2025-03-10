namespace Exercise02_04
{
    internal delegate int MyDelegate(int number);
    class PowersMaker
    {
        public MyDelegate this[int power]
        {
            get
            {
                return input=>
                {
                    int result = 1;
                    for (int i = 0; i < power; i++) result *= input;
                    return result;
                };
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PowersMaker Power = new PowersMaker();
            Console.WriteLine(Power[0](10)); // 1
            Console.WriteLine(Power[1](10)); // 10
            Console.WriteLine(Power[2](10)); // 100
            Console.WriteLine(Power[0](2)); // 1
            Console.WriteLine(Power[1](2)); // 2
            Console.WriteLine(Power[10](2)); // 1024
            Console.WriteLine(Power[9](-2)); // -512
        }
    }
}
