namespace Exercise05_02
{
    internal class Program
    {
        static int Read(string a)
        {
            int num = 0;
            bool success = false;
            Console.Write(a);
            while (!success)
            {
                try
                {
                    string input = Console.ReadLine();
                    if (input == "") Environment.Exit(0);
                    num = int.Parse(input);
                    success = true;
                }
                catch
                {
                    Console.Write("Вы ввели некорректное значение. Попробуйте ещё раз: ");
                }
            }
            return num;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int a, b;
                a = Read("Начало расчёта остатка от деления.\nВведите первое число: ");
                b = Read("Введите второе число: ");
                if (a < b) (a, b) = (b, a);
                try
                {
                    Console.WriteLine("Остаток от деления {0} на {1} составляет {2}", a, b, a % b);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Остаток от деления на ноль невозможен!");
                }
            }
        }
    }
}
