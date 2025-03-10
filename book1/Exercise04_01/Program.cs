namespace Exercise04_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint number = 0;
            System.Boolean failure;
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

            for (int i = 0; i < number; i++)
            {
                numbers[i] = 5 * i + 2;
            }

            Console.WriteLine("Вывод элементов массива:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0,5}", numbers[i]);
            }
        }
    }
}
