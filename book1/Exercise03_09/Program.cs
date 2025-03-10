using System.Diagnostics.Contracts;

namespace Ryabkin
{
        internal class Program
    {
        static void Main()
        {
            double first = 0, last = 0, increment = 0, i = 0;
            bool failure;

            Console.Title = "Последовательнсть между двух чисел";
            failure = true;
            while (failure)
            {
                Console.Write("Введите первое число: ");
                try
                {
                    first = double.Parse(Console.ReadLine());
                    failure = false;
                }
                catch
                {
                    Console.WriteLine("Вы ввели не число!");
                }
            }
            failure = true;
            while (failure)
            {
                Console.Write("Введите второе число: ");
                try
                {
                    last = double.Parse(Console.ReadLine());
                    failure = false;
                }
                catch
                {
                    Console.WriteLine("Вы ввели не число!");
                }
            }
            failure = true;
            while (failure)
            {
                Console.Write("Введите инкремент: ");
                try
                {
                    increment = double.Parse(Console.ReadLine());
                    failure = false;
                }
                catch
                {
                    Console.WriteLine("Вы ввели не число!");
                }
            }
            if (first > last) (first, last) = (last, first);
            if (increment > 0)
            {
                i = first;
                while (i <= last)
                {
                    Console.Write(i + "\n");
                    i += increment;
                }
            }
            else if (increment < 0)
            {
                i = last;
                while (i >= first)
                {
                    Console.Write(i + "\n");
                    i += increment;
                }
            }
            else
            {
                Console.WriteLine("Инкремент не может быть равен нулю! Пока.");
            }
            
        }
    }
}
