namespace Ryabkin
{
    internal class Program
    {
        static void Main()
        {
            uint n, i, sum;
            string input;

            Console.Title = "Сумма квадратов натуральных чисел";
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
                // Подсчёт
                sum = 0;
                i = 0;
            myMark:
                sum += i * i;
                if (++i <= n) goto myMark;

                if (sum == n * (n + 1) * (2 * n + 1) / 6)
                {
                    Console.WriteLine("Сумма первых " + n + " квадратов натуральных чисел равна " + sum);
                }
                else
                {
                    Console.WriteLine("Что-то не то в цикле...");
                }
                Console.Write("Введите количество элементов последовательности (выход для завершения): ");
            }

            Console.WriteLine("Спасибо за пользование нашей программой!");
        }
    }
}
