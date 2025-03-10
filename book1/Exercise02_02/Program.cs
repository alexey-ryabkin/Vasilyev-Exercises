namespace Exercise02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;

            Console.WriteLine("Введите целое число");
            input = Int32.Parse(Console.ReadLine());
            Console.WriteLine(input % 5 == 2 && input % 7 == 1?"Удовлетворяет":"Не удовлетворяет");
        }
    }
}
