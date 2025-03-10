namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(int) 12.4 / 3 = 4 = " + (int) (12.4 / 3));
            Console.WriteLine("12.4 % 3 = 0.4 = " + 12.4 % 3);
            Console.WriteLine("(int) -12.4 / 3 = -4 = " + (int) -12.4 / 3);
            Console.WriteLine("-12.4 % 3 = -0.4 = " + -12.4 % 3);
            Console.WriteLine("(int) (12.4 / -3) = -4 = " + (int) (12.4 / -3));
            Console.WriteLine("12.4 % -3 = 0.4 = " + 12.4 % -3);
            Console.WriteLine("(int) (-12.4 / -3) = 4 = " + (int) (-12.4 / -3));
            Console.WriteLine("-12.4 % -3 = -0.4 = " + -12.4 % -3);
        }
    }
}
