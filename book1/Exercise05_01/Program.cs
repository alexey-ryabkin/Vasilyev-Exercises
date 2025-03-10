namespace Exercise05_01
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

        static int doubleFactRec(int n)
        {
            if (n <= 2)
            {
                return n;
            }
            else
            {
                return n * doubleFactRec(n - 2);
            }
        }
        
        static int doubleFact(int n)
        {
            int result = n, counter = n;

            while (counter > 2)
            {
                counter -= 2;
                result *= counter;
            }

            return result;
        }
        
        static int Main(string[] args)
        {
            int n, result, resultFact;
            
            Console.Title = "Вычисление двойного факториала числа";
            n = InputInt();

            // Вычисление двойного факториала с рекурсией
            resultFact = doubleFactRec(n);

            // Без рекурсии
            result = doubleFact(n);

            Console.WriteLine("{0}!! = {1}", n, resultFact + " (через рекурсию)");
            Console.WriteLine("{0}!! = {1}", n, result);

            return 0;
        }
    }
}
