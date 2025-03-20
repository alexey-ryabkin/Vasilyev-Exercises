namespace Exercise05_03
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
            int A = Read("Начало решения уравления Ax = B на множестве целых чисел.\nВведите число A: ");
            int B = Read("Введите число B: ");
            if (A == 0 && B == 0) Console.WriteLine("x принадлежит множеству целых чисел.");
            else
            {
                try
                {
                    if (B % A == 0)
                    {
                        Console.WriteLine("x = " + B / A);
                    }
                    else 
                    {
                        throw new DivideByZeroException();
                    };
                }
                catch(DivideByZeroException)
                {
                    Console.WriteLine("x не принадлежит множеству целых чисел.");
                }
            }
            Console.WriteLine("Уравнение Ax = B решено на множестве целых чисел.");
        }
    }
}
