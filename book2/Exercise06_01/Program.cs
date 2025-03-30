namespace Exercise06_01
{
    internal class Program
    {
        static int input, sfact, sfact2, sfib;
        static int Read(string a, ref int target)
        {
            bool success = false;
            Console.Write(a);
            while (!success)
            {
                try
                {
                    string? input = Console.ReadLine();
                    if (input == "") Environment.Exit(0);
                    target = int.Parse(input!); // ! Подавляет предупреждение. Нас устраивает null, потому что мы в контролируемом коде.
                    success = true;
                }
                catch
                {
                    Console.Write("Вы ввели некорректное значение. Попробуйте ещё раз: ");
                }
            }
            return target;
        }
        static void CalculateFact()
        {
            int fact = 1;
            Console.WriteLine("Начало вычиления факториала.");
            for (int i = 2; i <= input; i++)
            {
                Console.WriteLine("{0} шаг факториала", i);
                fact *= i;
            }
            sfact = fact;
            //Console.WriteLine("{0}! = {1}", input, fact);
            Console.WriteLine("Вычисление факториала завершено.");
        }
        static void CalculateFact2()
        {
            int fact = 1;
            Console.WriteLine("Начало вычиления двойного факториала.");
            for (int i = input; i >= 1; i -= 2)
            {
                Console.WriteLine("{0} шаг двойного факториала", i);
                fact *= i;
            }
            sfact2 = fact;
            //Console.WriteLine("{0}!! = {1}", input, fact);
            Console.WriteLine("Вычисление двойного факториала завершено.");
        }
        static void CalculateFib()
        {
            Console.WriteLine("Начало вычиления число Фибоначчи.");
            int fib = 1;
            {
                int fibMinus1 = 1;
                for (int i = 3; i <= input; i++)
                {
                    Console.WriteLine("{0} шаг фибоначчи", i);
                    int temp = fib;
                    fib += fibMinus1;
                    fibMinus1 = temp;
                }
            }
            sfib = fib;
            //Console.WriteLine("{0} число Фибоначчи = {1}", input, fib);
            Console.WriteLine("Вычисление числа Фибоначчи завершено.");
        }
        static void Main(string[] args)
        {
            Read("Введите исходное число: ", ref input);
            ThreadStart threadStartFact = new ThreadStart(CalculateFact);
            ThreadStart threadStartFact2 = new ThreadStart(CalculateFact2);
            ThreadStart threadStartFib = new ThreadStart(CalculateFib);
            Thread Fact = new Thread(threadStartFact);
            Thread Fact2 = new Thread(threadStartFact2);
            Thread Fib = new Thread(threadStartFib);
            Fact.Start();
            Fact2.Start();
            Fib.Start();
            if (Fact.IsAlive) Fact.Join();
            if (Fact2.IsAlive) Fact2.Join();
            if (Fib.IsAlive) Fib.Join();
            Console.WriteLine("{0}! = {1}", input, sfact);
            Console.WriteLine("{0}!! = {1}", input, sfact2);
            Console.WriteLine("{0} число Фибоначчи = {1}", input, sfib);
        }
    }
}
