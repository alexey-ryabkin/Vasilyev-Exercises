namespace Exercise02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;

            Console.WriteLine("Введите целое число");
            input = Int32.Parse(Console.ReadLine());
            Console.WriteLine(input % 4 == 0 && input >= 10 ? "Удовлетворяет" : "Не удовлетворяет");
        }
    }
}
