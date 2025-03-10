namespace Exercise02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte input, input1;

            Console.WriteLine("Введите целое число");
            input = Byte.Parse(Console.ReadLine());
            input1 = (byte)(input << 5);
            input1 >>= 7;
            Console.WriteLine(input1);
            Console.WriteLine(Convert.ToString(input, 2));
        }
    }
}
