namespace Exercise01_02b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? weekday, month;
            int day;
            Console.Title = "Дни месяца";
            Console.WriteLine("Введите текущий день недели");
            weekday = Console.ReadLine();
            Console.WriteLine("Введите текущий месяц");
            month = Console.ReadLine();
            Console.WriteLine("Введите текущее число месяца");
            day = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Сегодня {0}, {1} месяца {2}", weekday, day, month);
        }
    }
}