namespace Exercise04_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int len = 100, min;
            int[] numbers = new int[len];
            Random rnd = new Random();

            Console.Write("Созданный массив: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(10);
                Console.WriteLine(numbers[i] + "\t");
            }

            min = numbers[0];
            // Определение минимального элемента
            foreach (int i in numbers)
            {
                if (min > i) min = i;
            }

            Console.WriteLine("Минимальное число массива — " + min);

            Console.Write("Индексы этого числа: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (min == numbers[i]) Console.Write("{0,4}", i);
            }
        }
    }
}
