namespace Exercise09_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? input;
            string[] inputs;
            int year1, year2;
            DateTime date;

            inputs = ["0", "0"];
            year1 = year2 = 0;
            Console.Write("Введите два года в формате гггг-гггг: ");
            input = Console.ReadLine();
            try
            {
                if (input != null)
                {
                    inputs = input.Split("-");
                }
                year1 = int.Parse(inputs[0]);
                year2 = int.Parse(inputs[1]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Неверный формат ввода.");
                Console.WriteLine(e.Message);
            }
            if (year1 > year2) (year1, year2) = (year2, year1);
            for (int i = year1;  i <= year2; i++)
            {
                date = new DateTime(i, 1, 1);
                if (date.DayOfWeek == DayOfWeek.Monday)
                {
                    Console.WriteLine(date.ToString("dd.MM.yyyy") + " — понедельник");
                }
            }
        }
    }
}
