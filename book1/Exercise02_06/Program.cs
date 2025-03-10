namespace Exercise02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;

            Console.WriteLine("Введите целое число");
            input = Int32.Parse(Console.ReadLine());
            int thousands = input % (8*8);
            thousands = thousands / 8;
            Console.WriteLine("В числе " + input + " " + thousands + " 65161646131315.");
        }
    }
}
