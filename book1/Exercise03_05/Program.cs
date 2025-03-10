namespace Ryabkin
{
    internal class Program
    {
        static void Main()
        {
            int dayNumber = 0, dayNumber1 = 0;
            string input;

            Console.Title = "Определение номера дня недели";
            // Получение значений от пользователя.
            Console.Write("Введите название дня недели: ");
            while (true)
            {
                input = Console.ReadLine();
                if (input == "0") break;
                input = input.ToLower();
                switch (input)
                {
                    case "понедельник":
                        dayNumber = 1;
                        break;
                    case "вторник":
                        dayNumber = 2;
                        break;
                    case "среда":
                        dayNumber = 3;
                        break;
                    case "четверг":
                        dayNumber = 4;
                        break;
                    case "пятница":
                        dayNumber = 5;
                        break;
                    case "суббота":
                        dayNumber = 6;
                        break;
                    case "воскресенье":
                        dayNumber = 7;
                        break;
                    default:
                        Console.WriteLine("Дня недели с таким назнванием не существует(");
                        Console.Write("Введите название дня недели (0 для завершения): ");
                        continue;
                }
                if (input == "понедельник") dayNumber1 = 1;
                else if (input == "вторник") dayNumber1 = 2;
                else if (input == "среда") dayNumber1 = 3;
                else if (input == "четверг") dayNumber1 = 4;
                else if (input == "пятница") dayNumber1 = 5;
                else if (input == "суббота") dayNumber1 = 6;
                else if (input == "воскресенье") dayNumber1 = 7;

                Console.WriteLine("Номер данного дня недели — " + dayNumber + ", " + dayNumber1);
                Console.Write("Введите название дня недели (0 для завершения): ");
            }

            Console.WriteLine("Спасибо за пользование нашей программой!");
        }
    }
}
