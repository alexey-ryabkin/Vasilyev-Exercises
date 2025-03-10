namespace Ryabkin
{
    internal class Program
    {
        static void Main()
        {
            uint n, i, a = 0, b = 0, c = 0;
            string input;

            Console.Title = "Последовательность Фибоначчи";
            // Получение значений от пользователя.
            Console.Write("Введите количество элементов последовательности: ");
            while (true)
            {
                input = Console.ReadLine();
                if (input == "выход") break;
                try
                {
                    n = uint.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Данное число не натурально.");
                    Console.Write("Введите количество элементов последовательности (выход для завершения): ");
                    continue;
                }
                // Сбор и вывод последовательности
                i = 1;
                a = b = c = 0;
                while (i <= n)
                {
                    if (i == 1) Console.Write((b = 0) + " ");
                    else if (i == 2) Console.Write((b = 1) + " ");
                    else
                    {
                        c = a + b;
                        a = b;
                        b = c;
                        Console.Write(c + " ");
                    }
                    i++;
                }
                Console.WriteLine();
                Console.Write("Введите количество элементов последовательности (выход для завершения): ");
            }
            Console.WriteLine("Спасибо за пользование нашей программой!");
        }
    }
}
