namespace Exercise04_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int size = 250;
            int[] a = new int[size];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rng.Next(1010);
            }
            Console.WriteLine("Исходный массив:");

            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Метод пузырька.. Bubble sort
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        (a[j], a[j + 1]) = (a[j + 1], a[j]);
                    }
                }
            }
            Console.WriteLine("Отсортированный массив:");

            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
