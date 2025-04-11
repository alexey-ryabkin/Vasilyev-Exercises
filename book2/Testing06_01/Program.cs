namespace Testing06_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1111Начало программы, неконтролируемый код");
            try
            {
                Console.WriteLine("2222Блок контролируемого кода");
                try
                {
                    //throw new Exception();
                    //throw new ArithmeticException();
                    Console.WriteLine("   3Блок контролируемого кода внутри блока контролируемого кода");
                }
                catch(ArithmeticException e)
                {
                    Console.WriteLine("33  Внутренний блок обработки исключений");
                    //throw new Exception();
                }
                finally
                {
                    Console.WriteLine("?434Внутренний блок обязательного выполнения");
                    //  Данный finally отличается от обычного блока контролируемого кода тем,
                    //  что выполняется даже если исключение не было поймано блоком catch

                    // Результат эксперимента: блок finally выполняется даже если исключение было сгенерировано
                    // внутри блока catch. Хорошо, так и ожидалось.
                }
                Console.WriteLine(" 5 5Блок контролируемого кода после блока обязательного выполнения");
            }
            catch
            {
                Console.WriteLine("5 4 Внешний блок обработки исключений");
            }
            finally
            {
                Console.WriteLine("6656Внешний блок обязательного кода, аналогичен простому коду");
                // Данный finally аналогичен неконтролируемому коду ниже,
                // так как он находится за пределами контролируемого кода
            }
        }
    }
}
