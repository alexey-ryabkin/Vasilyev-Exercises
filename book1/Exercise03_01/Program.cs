namespace Exercise03_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, div3Remainder, div7Remainder;
            bool failure, divBy3, divBy7;
            string output;

            Console.Title = "Проверка делимости на 3 и 7";
            // Получение значения от пользователя.
            do
            {
                try
                {
                    Console.Write("Введите, пожалуйста, целое число: ");
                    number = int.Parse(Console.ReadLine());

                    // Всё назначилось нормально. Последняя строчка для выхода из цикла.
                    failure = false;
                }
                catch
                {
                    Console.WriteLine("К сожалению, произошла ошибка. Скорее всего, вы ввели не целое число. Попробуйте ещё раз.");
                    failure = true;
                    // Фальшивое значение, иначе ругается компилятор..
                    number = 0;
                }
            } while(failure);

            // В данной точке значение number гарантированно назначено.
            // Выполнение самой программы.
            div3Remainder = number % 3;
            div7Remainder = number % 7;
            divBy3 = div3Remainder == 0;
            divBy7 = div7Remainder == 0;

            output = "Введённое число — " + number + "!";
            if (divBy3)
                output += "\nОно делится на 3 без остатка.";
            else
                output += "\nОно делится на 3 с остатком " + div3Remainder + ".";
            if (divBy7)
                output += "\nОно делится на 7 без остатка.";
            else
                output += "\nОно делится на 7 с остатком " + div7Remainder + ".";

            Console.WriteLine(output);
        }
    }
}
