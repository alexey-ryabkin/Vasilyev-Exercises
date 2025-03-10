namespace Ryabkin
{
    internal class Program
    {
        static void Main()
        {
            uint n, i, sum;
            string input;

            Console.Title = "Сумма последовательности нечётных чисел";
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
                for 
                (
                    i = 0; 
                    i <= n; 
                    i++
                )
                {
                    sum += 2 * i;
                }

                if (sum == n * (n + 1))
                {
                    Console.WriteLine("Сумма первых " + n + " чётных чисел равна " + sum);
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
