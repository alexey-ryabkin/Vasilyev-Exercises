namespace Exercise04_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint number = 0;
            bool failure;
            int[] numbers;

            do
            {

                try
                {
                    Console.Write("Введите число элементов массива: ");
                    number = uint.Parse(Console.ReadLine());
                    failure = false;
                }
                catch
                {
                    Console.WriteLine("Вы ввели некорректное целое неотрицательное число!");
                    failure = true;
                }
            } while (failure);

            numbers = new int[number];
            if (number > 0)
            {
                numbers[0] = 1;
            }

            for (int i = 1; i < number; i++)
            {
                numbers[i] = numbers[i-1] * 2;
            }

            Console.WriteLine("Вывод элементов массива:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0,5}", numbers[i]);
            }
        }
    }
}
