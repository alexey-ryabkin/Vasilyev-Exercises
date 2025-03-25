namespace Exercise05_04
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
            // Не уверен, какие здесь можно было использовать исключения. Sqrt выдаёт NaN вместо исключения.
            double A, B, C, D, Dsq, x1, x2;
            Console.Title = "Решение квадратного трёхчлена";
            Console.WriteLine("Начало решения квадратного уравнения вида Ax^2 + Bx + C = 0.");
            A = Read("Введите старший член A: ");
            B = Read("Введите свободный член B: ");
            C = Read("Введите свободнцый член C: ");
            Console.WriteLine("Введённое уравнение {0}x^2 + {1}x + {2} = 0", A, B, C);
            D = B * B - 4 * A * C;
            if (A == 0) Console.WriteLine("Введённое уравнение не квадратное.");
            else
            {
                Console.Write("Дискриминант равен {0}", D);
                switch (D)
                {
                    case > 0:
                        Console.WriteLine(" > 0 => существует два действительных решения.");
                        Dsq = Math.Sqrt(D);
                        x1 = (-B + Dsq) / (2 * A);
                        x2 = (-B - Dsq) / (2 * A);
                        Console.WriteLine("Решения уравнения:\nx1 = {0:0.000};\nx2 = {1:0.000}.", x1, x2);
                        break;
                    case 0:
                        Console.WriteLine(" = 0 => действительное решение единственно.");
                        x1 = -B / (2 * A);
                        Console.WriteLine("Решение уравнения: x = {0:0.000}.", x1);
                        break;
                    default:
                        Console.WriteLine(" < 0 => действительных решений не существует.");
                        break;
                }

            }
        }
    }
}
