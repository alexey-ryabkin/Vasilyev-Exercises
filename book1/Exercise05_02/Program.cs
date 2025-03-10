
namespace Exercise05_02
{
    internal class Program
    {
        static int InputInt()
        {
            bool failure = true;
            int n = 0;
            while (failure)
            {
                Console.WriteLine("Введите натуральное число: ");
                try
                {
                    n = Int32.Parse(Console.ReadLine());
                    failure = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Вы ввели не натуральное число!");
                }
            }
            return n;
        }

        static int doubleSquareRec(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n*n + doubleSquareRec(n - 1);
            }
        }

        static int doubleSquare(int n)
        {
            int result = n * n, counter = n;

            while (counter > 0)
            {
                counter -= 1;
                result += counter * counter;
            }

            return result;
        }

        static int Main(string[] args)
        {
            int n, result, resultFact;

            Console.Title = "Вычисление суммы квадратов";
            n = InputInt();

            // Вычисление суммы квадратов с рекурсией
            resultFact = doubleSquareRec(n);

            // Без рекурсии
            result = doubleSquare(n);

            Console.WriteLine("Σ(1² .. {0}²) = {1}", n, resultFact + " (через рекурсию)");
            Console.WriteLine("Σ(1² .. {0}²) = {1}", n, result);
            Console.WriteLine("Правильный ответ: {0}", n * (n + 1) * (2 * n + 1) / 6);

            return 0;
        }
    }
}
