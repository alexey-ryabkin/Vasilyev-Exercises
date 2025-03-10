namespace Ryabkin
{
    internal class Program
    {
        static void Main()
        {
            double sum = 0, current;
            string input;

            Console.Title = "Подсчёт суммы чисел";
            // Получение значений от пользователя.
            Console.Write("Введите первое число последовательности: ");
            while (true)
            {
                input = Console.ReadLine();
                if (input == "0") break;
                try
                {
                    current = double.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Введённое число некорректно и не будет учтено.");
                    Console.Write("Введите последующее число (0 для завершения): ");
                    continue;
                }
                sum += current;
                Console.Write("Введите последующее число (0 для завершения): ");
            }

            Console.WriteLine("Сумма введённых значений — " + sum);
        }
    }
}
