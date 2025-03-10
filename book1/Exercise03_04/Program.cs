namespace Ryabkin
{
    internal class Program
    {
        static void Main()
        {
            int number;
            string input, weekday = "Не назначен";

            Console.Title = "Определение дня недели";
            // Получение значений от пользователя.
            Console.Write("Введите номер дня недели: ");
            while (true)
            {
                input = Console.ReadLine();
                if (input == "0") break;
                try
                {
                    number = int.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Введённое число некорректно не может быть переведено в день недели.");
                    Console.Write("Введите номер дня недели (0 для завершения): ");
                    continue;
                }

                switch (number)
                {
                    case 1:
                        weekday = "Понедельник";
                        break;
                    case 2:
                        weekday = "Вторник";
                        break;
                    case 3:
                        weekday = "Среда";
                        break;
                    case 4:
                        weekday = "Четверг";
                        break;
                    case 5:
                        weekday = "Пятница";
                        break;
                    case 6:
                        weekday = "Суббота";
                        break;
                    case 7:
                        weekday = "Воскресенье";
                        break;
                    default:
                        Console.WriteLine("Дня недели с таким номером не существует(");
                        Console.Write("Введите номер дня недели (0 для завершения): ");
                        continue;
                }

                Console.WriteLine("День недели с данным номером — " + weekday);
                Console.Write("Введите номер дня недели (0 для завершения): ");
            }

            Console.WriteLine("Спасибо за пользование нашей программой!");
        }
    }
}
