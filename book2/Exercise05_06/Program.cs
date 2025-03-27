namespace Exercise05_06
{
    enum IsEven : byte { Unknown = 0, Even = 1, Odd = 2 };
    internal class Program
    {
        static void ExeptIsEven(int num)
        {
            if (num % 2 == 0) throw new ArithmeticException("Число чётное.");
            else throw new OverflowException("Число нечётное.");
        }
        static void Main(string[] args)
        {
            while (true)
            {
                IsEven iseven = new IsEven();
                Console.Write("Введите целое число (exit для выхода): ");
                try
                {
                    try
                    {
                        int num = int.Parse(Console.ReadLine());
                        ExeptIsEven(num);
                    }
                    catch (OverflowException) { iseven = IsEven.Odd; }
                    catch (ArithmeticException) { iseven = IsEven.Even; }
                    finally
                    {
                        switch (iseven)
                        {
                            case IsEven.Unknown:
                                Console.WriteLine("Чётность числа, к сожалению, не определена, так как выполнение программы завершено.");
                                break;
                            case IsEven.Even:
                                Console.WriteLine("Число чётное");
                                break;
                            case IsEven.Odd:
                                Console.WriteLine("Число нечётное");
                                break;
                        }
                    }
                }
                catch
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
